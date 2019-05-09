using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class EventDispatcher
    {
        private static EventDispatcher Instance;

        private Dictionary<string, EventHandler<EventArgs>>
            dicEventHandler = new Dictionary<string, EventHandler<EventArgs>>();


        private EventDispatcher()
        {
            if (EventDispatcher.Instance != null)
            {
                throw new Exception("EventDispatcher는 싱글톤 클래스 입니다.");
            }

        }

        public static EventDispatcher GetInstance()
        {
            if (EventDispatcher.Instance == null)
            {
                EventDispatcher.Instance = new EventDispatcher();
            }
            return EventDispatcher.Instance;
        }

        //이벤트 핸들러 등록 
        public void AddEventHandler(
            string eventName, 
            EventHandler<EventArgs> handler)
        {
            if (!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, handler);

                Console.WriteLine("이벤트 ({0})가 등록 되었습니다. {1}", eventName, handler);
                Console.WriteLine("this.dicEventHandler.Count: {0}", this.dicEventHandler.Count);
            }

        }

        //이벤트 발생
        public void DispatchEvent(string eventName, EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];

            Console.WriteLine("DispatchEvent: " + dicEventHandler.Count);

            Console.WriteLine("DispatchEvent: " + dicEventHandler.ContainsKey(eventName));

            Console.WriteLine("handler: " + handler);

            handler?.Invoke(EventDispatcher.GetInstance(), e);
        }
    }
}
