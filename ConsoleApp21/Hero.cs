using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Hero
    {
        public string Name { get; private set; }

        public void Init(string name)
        {
            this.Name = name;
        }

        public void ActiveSkill()
        {
            Console.WriteLine("{0}이(가) 스킬을 사용했습니다.", this.Name);
        }
    }
}
