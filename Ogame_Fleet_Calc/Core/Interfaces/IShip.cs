using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataContainers.Structs;

namespace Core.Interfaces
{
    /// <summary>
    /// Represents a ship object
    /// </summary>
    interface IShip
    {
        /// <summary>
        /// The name of the ship
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The price to pay for the ship
        /// </summary>
        Price ShipCost { get; set; }
    }
}
