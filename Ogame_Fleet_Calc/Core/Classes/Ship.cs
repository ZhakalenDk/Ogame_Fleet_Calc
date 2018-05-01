using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataContainers.Enums;
using Core.DataContainers.Structs;
using Core.Interfaces;

namespace Core.Classes
{
    /// <summary>
    /// Represents a ship object
    /// </summary>
    public class Ship : IShip
    {
        /// <summary>
        /// The type of the ship
        /// </summary>
        public ShipType Type { get;}
        /// <summary>
        /// HOw much the ship costs to build
        /// </summary>
        public Price ShipCost { get; }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="_type">The type of the ship</param>
        /// <param name="_shipCost">The cost of building the ship</param>
        public Ship( ShipType _type, Price _shipCost )
        {
            Type = _type;
            ShipCost = _shipCost;
        }

        /// <summary>
        /// Convets the ship object into a formatted string printable in the console
        /// </summary>
        /// <returns></returns>
        public string Format_To_Console()
        {
            return $"{Type}\n}}\n    Cost:\n    {{\n        {ShipCost.Format_To_Console ( "        " )}\n    }}\n}}";
        }

        public static Price operator +( Ship _shipA, Ship _shipB )
        {
            return _shipA.ShipCost + _shipB.ShipCost;
        }
        public static Price operator *( Ship _ship, int _num )
        {
            Price newPrice = new Price ( _ship.ShipCost.MetalCost * _num, _ship.ShipCost.CrystalCost * _num, _ship.ShipCost.DeuteriumCost * _num );

            return newPrice;
        }
    }
}
