using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataContainers.Structs;
using Core.DataContainers.Enums;

namespace Core.Interfaces
{
    /// <summary>
    /// Represents a ship object
    /// </summary>
    public interface IShip
    {
        /// <summary>
        /// The name of the ship
        /// </summary>
        ShipType Type { get; set; }
        /// <summary>
        /// The price to pay for the ship
        /// </summary>
        Price ShipCost { get; set; }
        /// <summary>
        /// Convets the ship object into a formatted string printable in the console
        /// </summary>
        /// <returns></returns>
        string Format_To_Console();
    }
}
