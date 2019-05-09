using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class App
    {
        private GameLauncher launcher;

        public void Start()
        {
            launcher = new GameLauncher();
            launcher.Init();
            launcher.Start();
        }
    }
}
