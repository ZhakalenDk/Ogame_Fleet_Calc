using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEvent
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The event
        /// </summary>
        void Event();
    }
}
