using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.EventSystem
{
    public class EventManager
    {
        private static EventManager EM;
        /// <summary>
        /// A global refrence to the event class
        /// </summary>
        public static EventManager Instance
        {
            get
            {
                if ( EM == null )
                {
                    EM = new EventManager ();

                    if ( EM == null )
                    {
                        throw new NullReferenceException ();
                    }

                    Instance.Initialize ();
                }

                return EM;
            }
        }

        /// <summary>
        /// A collection of all raised event
        /// </summary>
        private Dictionary<string, Action<object, EventArgs>> Events;

        /// <summary>
        /// Add an event to the event collection.
        /// </summary>
        /// <param name="_eventName">The name of the event</param>
        /// <param name="_event">The method associated with the event</param>
        public void Start_Listen_To( string _eventName, Action<object, EventArgs> _event )
        {
            if ( !Events.TryGetValue ( _eventName, out Action<object, EventArgs> thisEvent ) )
            {
                Events.Add ( _eventName, _event );
            }

        }

        /// <summary>
        /// Remove an event from the event collection
        /// </summary>
        /// <param name="_eventName">The name of the event</param>
        public void Stop_Listening_To( string _eventName )
        {
            Events.Remove ( _eventName );
        }

        /// <summary>
        /// GEt an event from the event collection. Will return null if the event is not in the collection
        /// </summary>
        /// <param name="_eventName">The name of the event</param>
        /// <returns></returns>
        public Action<object, EventArgs> Get_Event ( string _eventName )
        {
            //  If the event is in the collection, return it. If not return null
            if ( Events.TryGetValue ( _eventName, out Action<object, EventArgs> thisEvent ) )
            {
                return thisEvent;
            }

            return null;
        }

        /// <summary>
        /// Initialize the event collection
        /// </summary>
        private void Initialize()
        {
            Instance.Events = new Dictionary<string, Action<object, EventArgs>> ();
        }
    }
}
