using Core.DataContainers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    /// <summary>
    /// Represents a fleet
    /// </summary>
    public class Fleet
    {
        /// <summary>
        /// The name of the fleet
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The amount of small cargo ships currently in the fleet
        /// </summary>
        public int SmallCargoes { get; private set; }
        /// <summary>
        /// The amount of light figthers currently in the fleetm
        /// </summary>
        public int LightFighters { get; private set; }
        /// <summary>
        /// The amount of large cargo ships currently in the fleet
        /// </summary>
        public int LargeCargoShips { get; private set; }
        /// <summary>
        /// The amount of heavy figthers currently in the fleet
        /// </summary>
        public int HeavyFighters { get; private set; }
        /// <summary>
        /// The amount of cruisers currently in the fleet
        /// </summary>
        public int Cruisers { get; private set; }
        /// <summary>
        /// The amount of battleships currently in the fleet
        /// </summary>
        public int Battleships { get; private set; }
        /// <summary>
        /// The amount of battlecruisers currently in the fleet
        /// </summary>
        public int Battlecruisers { get; private set; }
        /// <summary>
        /// The amount of destroyers currently in the fleet
        /// </summary>
        public int Destroyers { get; private set; }
        /// <summary>
        /// The amount of deathstars currently in the fleet
        /// </summary>
        public int Deathstars { get; private set; }
        /// <summary>
        /// The amount of bombers currently in the fleet
        /// </summary>
        public int Bombers { get; private set; }
        /// <summary>
        /// The amount of recyclers currently in the fleet
        /// </summary>
        public int Recyclers { get; private set; }
        /// <summary>
        /// The amount of espionage probes currently in the fleet
        /// </summary>
        public int EspionageProbes { get; private set; }
        /// <summary>
        /// The amount of colony ships currently in the fleet
        /// </summary>
        public int ColonyShips { get; private set; }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="_name">The name of the fleet</param>
        public Fleet( string _name )
        {
            Name = _name;
            SmallCargoes = 0;
            LargeCargoShips = 0;
            LightFighters = 0;
            HeavyFighters = 0;
            Cruisers = 0;
            Battleships = 0;
            Battlecruisers = 0;
            Destroyers = 0;
            Deathstars = 0;
            Bombers = 0;
            Recyclers = 0;
            ColonyShips = 0;
        }

        /// <summary>
        /// Add an amount of a specific ship type to a fleet
        /// </summary>
        /// <param name="_type">The type of the ship</param>
        /// <param name="_amount">The amount of ships to add</param>
        public void Add_ship( ShipType _type, int _amount )
        {
            _amount = ( ( _amount < 0 ) ? ( 0 ) : ( _amount ) );
            //  Adds the amount of ships to the specific type, specefied by the ShipType enum
            switch ( _type )
            {
                case ShipType.SmallCargoShip:
                    SmallCargoes += _amount;
                    break;
                case ShipType.LargeCargoShip:
                    LargeCargoShips += _amount;
                    break;
                case ShipType.LightFighter:
                    LightFighters += _amount;
                    break;
                case ShipType.HeavyFighter:
                    HeavyFighters += _amount;
                    break;
                case ShipType.Cruiser:
                    Cruisers += _amount;
                    break;
                case ShipType.Battleship:
                    Battleships += _amount;
                    break;
                case ShipType.Battlecruiser:
                    Battlecruisers += _amount;
                    break;
                case ShipType.Destroyer:
                    Destroyers += _amount;
                    break;
                case ShipType.Deathstar:
                    Deathstars += _amount;
                    break;
                case ShipType.Bomber:
                    Bombers += _amount;
                    break;
                case ShipType.Recycler:
                    Recyclers += _amount;
                    break;
                case ShipType.EspionageProbe:
                    EspionageProbes += _amount;
                    break;
                case ShipType.ColonyShip:
                    ColonyShips += _amount;
                    break;
                default:
                    throw new KeyNotFoundException ( "Error in Fleet.Add_Ship(ShipType, int) - invalid data in Switch (_type):  default" );
            }
        }

        /// <summary>
        /// Remove an amount of a specefic ship type from a fleet
        /// </summary>
        /// <param name="_type">THe type of the ship</param>
        /// <param name="_amount">The amount to remove</param>
        public void Remove_Ship(ShipType _type, int _amount )
        {
            _amount = ( ( _amount < 0 ) ? ( 0 ) : ( _amount ) );
            //  Adds the amount of ships to the specific type, specefied by the ShipType enum
            switch ( _type )
            {
                case ShipType.SmallCargoShip:
                    SmallCargoes -= _amount;
                    break;
                case ShipType.LargeCargoShip:
                    LargeCargoShips -= _amount;
                    break;
                case ShipType.LightFighter:
                    LightFighters -= _amount;
                    break;
                case ShipType.HeavyFighter:
                    HeavyFighters -= _amount;
                    break;
                case ShipType.Cruiser:
                    Cruisers -= _amount;
                    break;
                case ShipType.Battleship:
                    Battleships -= _amount;
                    break;
                case ShipType.Battlecruiser:
                    Battlecruisers -= _amount;
                    break;
                case ShipType.Destroyer:
                    Destroyers -= _amount;
                    break;
                case ShipType.Deathstar:
                    Deathstars -= _amount;
                    break;
                case ShipType.Bomber:
                    Bombers -= _amount;
                    break;
                case ShipType.Recycler:
                    Recyclers -= _amount;
                    break;
                case ShipType.EspionageProbe:
                    EspionageProbes -= _amount;
                    break;
                case ShipType.ColonyShip:
                    ColonyShips -= _amount;
                    break;
                default:
                    throw new KeyNotFoundException ( "Error in Fleet.Remove_Ship(ShipType, int) - invalid data in Switch (_type):  default" );
            }
        }

        /// <summary>
        /// Convets the Fleet object into a formatted string printable in the console
        /// </summary>
        /// <returns></returns>
        public string Format_To_Console()
        {
            return $"Fleet: {Name}\n{{\n    Small Cargo Ships : {SmallCargoes}\n    Large Cargo Ships : {LargeCargoShips}\n    Light Fighters    : {LightFighters}\n    Heavy Fighters    : {HeavyFighters}\n    Cruisers          : {Cruisers}\n    Battleships       : {Battleships}\n    Battlecruisers    : {Battlecruisers}\n    Destroyers        : {Destroyers}\n    Deathstars        : {Deathstars}\n    Bombers           : {Bombers}\n    Recyclers         : {Recyclers}\n    Colony Ships      : {ColonyShips}";
        }

        public static Fleet operator +( Fleet _fleetA, Fleet _fleetB )
        {
            Fleet newFleet = new Fleet ( _fleetA.Name );
            newFleet.SmallCargoes = _fleetA.SmallCargoes + _fleetB.SmallCargoes;
            newFleet.LargeCargoShips = _fleetA.LargeCargoShips + _fleetB.LargeCargoShips;
            newFleet.LightFighters = _fleetA.LightFighters + _fleetB.LightFighters;
            newFleet.HeavyFighters = _fleetA.HeavyFighters + _fleetB.HeavyFighters;
            newFleet.Cruisers = _fleetA.Cruisers + _fleetB.Cruisers;
            newFleet.Battleships = _fleetA.Battleships + _fleetB.Battleships;
            newFleet.Battlecruisers = _fleetA.Battlecruisers + _fleetB.Battlecruisers;
            newFleet.Destroyers = _fleetA.Destroyers + _fleetB.Destroyers;
            newFleet.Deathstars = _fleetA.Deathstars + _fleetB.Deathstars;
            newFleet.Bombers = _fleetA.Bombers + _fleetB.Bombers;
            newFleet.Recyclers = _fleetA.Recyclers + _fleetB.Recyclers;
            newFleet.EspionageProbes = _fleetA.EspionageProbes + _fleetB.EspionageProbes;
            newFleet.ColonyShips = _fleetA.ColonyShips + _fleetB.ColonyShips;

            return newFleet;
        }
    }
}
