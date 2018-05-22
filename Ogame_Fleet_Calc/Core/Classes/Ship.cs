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
        /// The name of the ship
        /// </summary>
        public string Name { get; private set; }
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
            Name = ShipType_To_Name ();
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

        /// <summary>
        /// Sets the name of the ship based on the shiptype
        /// </summary>
        /// <returns></returns>
        private string ShipType_To_Name()
        {
            string name;
            switch ( Type )
            {
                case ShipType.SmallCargoShip:
                    name = "Small Cargo ship";
                    break;
                case ShipType.LargeCargoShip:
                    name = "Large Cargo Ship";
                    break;
                case ShipType.LightFighter:
                    name = "Light Fighter";
                    break;
                case ShipType.HeavyFighter:
                    name = "Heavy Fighter";
                    break;
                case ShipType.Cruiser:
                    name = "Cruiser";
                    break;
                case ShipType.Battleship:
                    name = "Battleship";
                    break;
                case ShipType.Battlecruiser:
                    name = "Battlecruiser";
                    break;
                case ShipType.Destroyer:
                    name = "Destroyer";
                    break;
                case ShipType.Deathstar:
                    name = "Deathstar";
                    break;
                case ShipType.Bomber:
                    name = "Bomber";
                    break;
                case ShipType.Recycler:
                    name = "Recycler";
                    break;
                case ShipType.EspionageProbe:
                    name = "EspionageProbe";
                    break;
                case ShipType.ColonyShip:
                    name = "ColonyShip";
                    break;
                default:
                    name = null;
                    break;
            }
            return name;
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
