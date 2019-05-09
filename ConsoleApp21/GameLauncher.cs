using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class GameLauncher
    {
        public InGameUI inGameUI;
        private Hero hero;
        private Monster monster;

        //생성자 
        public GameLauncher()
        {
            this.inGameUI = new InGameUI();

            //이벤트 등록 

            EventDispatcher.GetInstance().AddEventHandler("MONSTER_DIE", (sender, e) => {
                Console.WriteLine("sender: {0}, e: {1}", sender, e);
                var eventArgs = (GameEvent.MonsterEventArgs)e;
                Console.WriteLine("id: {0}, hp: {1}", eventArgs.info.id, eventArgs.info.hp);
            });


            //버튼 이벤트 
            this.inGameUI.BtnHeroSkill.OnClickEventHandler 
                += BtnHeroSkill_OnClickEventHandler;
        }

        private void BtnHeroSkill_OnClickEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("{0}, {1}", sender, e);
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

        public void Init()
        {
            this.hero = new Hero();
            this.monster = new Monster();

            hero.Init("홍길동");
            this.monster.Init("오우거");

            Console.WriteLine("게임이 준비 되었습니다.");
        }

        public void Start()
        {
            Console.WriteLine("게임이 시작되었습니다.");
            //사용자가 눌렀다고 치자 
            this.inGameUI.BtnHeroSkill.Click();
        }
    }
}
