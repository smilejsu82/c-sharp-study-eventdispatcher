using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class UIButton
    {
        public event EventHandler OnClickEventHandler;

        //생성자 
        public UIButton()
        {
            
        }

        public void Click()
        {
            //이벤트 발생 
            this.OnClickEvent(EventArgs.Empty);
        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = OnClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
