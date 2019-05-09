using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class InGameUI
    {
        private UIGauge monsterHpGauge;
        private UIGauge heroHpGauge;
        public UIButton BtnHeroSkill { get; private set; }

        //생성자 
        public InGameUI()
        {
            this.monsterHpGauge = new UIGauge();
            this.heroHpGauge = new UIGauge();
            this.BtnHeroSkill = new UIButton();
        }
    }
}
