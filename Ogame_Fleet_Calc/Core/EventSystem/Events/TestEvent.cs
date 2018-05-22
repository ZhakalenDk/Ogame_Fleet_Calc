using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.EventSystem;

namespace Core.EventSystem.Events
{
    public class TestEvent : IEvent
    {
        public string Name { get; }

        public TestEvent(string _name )
        {
            Name = _name;
            EventManager.Instance.Start_Listen_To ( _name, Event );
        }

        ~TestEvent()
        {
            EventManager.Instance.Stop_Listening_To ( Name );
            Console.WriteLine ( $"I, {Name}, have been terminated" );
        }

        public void Event()
        {
            Console.WriteLine ( "I am an event!" );
        }
    }
}
