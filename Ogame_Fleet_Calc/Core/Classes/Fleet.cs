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
        /// A list of ship that is currently in the fleet
        /// </summary>
        public int [] Ships { get; private set; }

        ///// <summary>
        ///// The amount of small cargo ships currently in the fleet
        ///// </summary>
        //public int SmallCargoes { get; private set; }
        ///// <summary>
        ///// The amount of light figthers currently in the fleetm
        ///// </summary>
        //public int LightFighters { get; private set; }
        ///// <summary>
        ///// The amount of large cargo ships currently in the fleet
        ///// </summary>
        //public int LargeCargoShips { get; private set; }
        ///// <summary>
        ///// The amount of heavy figthers currently in the fleet
        ///// </summary>
        //public int HeavyFighters { get; private set; }
        ///// <summary>
        ///// The amount of cruisers currently in the fleet
        ///// </summary>
        //public int Cruisers { get; private set; }
        ///// <summary>
        ///// The amount of battleships currently in the fleet
        ///// </summary>
        //public int Battleships { get; private set; }
        ///// <summary>
        ///// The amount of battlecruisers currently in the fleet
        ///// </summary>
        //public int Battlecruisers { get; private set; }
        ///// <summary>
        ///// The amount of destroyers currently in the fleet
        ///// </summary>
        //public int Destroyers { get; private set; }
        ///// <summary>
        ///// The amount of deathstars currently in the fleet
        ///// </summary>
        //public int Deathstars { get; private set; }
        ///// <summary>
        ///// The amount of bombers currently in the fleet
        ///// </summary>
        //public int Bombers { get; private set; }
        ///// <summary>
        ///// The amount of recyclers currently in the fleet
        ///// </summary>
        //public int Recyclers { get; private set; }
        ///// <summary>
        ///// The amount of espionage probes currently in the fleet
        ///// </summary>
        //public int EspionageProbes { get; private set; }
        ///// <summary>
        ///// The amount of colony ships currently in the fleet
        ///// </summary>
        //public int ColonyShips { get; private set; }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="_name">The name of the fleet</param>
        public Fleet( string _name )
        {
            Name = _name;

            Ships = new int [13];   //  Initialize array
        }

        /// <summary>
        /// Add an amount of a specific ship type to a fleet
        /// </summary>
        /// <param name="_type">The type of the ship</param>
        /// <param name="_amount">The amount of ships to add</param>
        public void Add_ship( ShipType _type, int _amount )
        {
            _amount = ( ( _amount < 0 ) ? ( 0 ) : ( _amount ) );    //  If the amount of ships added is less than zero, set amount to 0
            #region Old code
            ////  Adds the amount of ships to the specific type, specefied by the ShipType enum
            //switch ( _type )
            //{
            //    case ShipType.SmallCargoShip:
            //        SmallCargoes += _amount;
            //        break;
            //    case ShipType.LargeCargoShip:
            //        LargeCargoShips += _amount;
            //        break;
            //    case ShipType.LightFighter:
            //        LightFighters += _amount;
            //        break;
            //    case ShipType.HeavyFighter:
            //        HeavyFighters += _amount;
            //        break;
            //    case ShipType.Cruiser:
            //        Cruisers += _amount;
            //        break;
            //    case ShipType.Battleship:
            //        Battleships += _amount;
            //        break;
            //    case ShipType.Battlecruiser:
            //        Battlecruisers += _amount;
            //        break;
            //    case ShipType.Destroyer:
            //        Destroyers += _amount;
            //        break;
            //    case ShipType.Deathstar:
            //        Deathstars += _amount;
            //        break;
            //    case ShipType.Bomber:
            //        Bombers += _amount;
            //        break;
            //    case ShipType.Recycler:
            //        Recyclers += _amount;
            //        break;
            //    case ShipType.EspionageProbe:
            //        EspionageProbes += _amount;
            //        break;
            //    case ShipType.ColonyShip:
            //        ColonyShips += _amount;
            //        break;
            //    default:
            //        throw new KeyNotFoundException ( "Error in Fleet.Add_Ship(ShipType, int) - invalid data in Switch (_type):  default" );
            //} 
            #endregion

            Ships [(int) _type] = _amount;
        }

        /// <summary>
        /// Remove an amount of a specefic ship type from a fleet
        /// </summary>
        /// <param name="_type">THe type of the ship</param>
        /// <param name="_amount">The amount to remove</param>
        public void Remove_Ship( ShipType _type, int _amount )
        {
            _amount = ( ( _amount < 0 ) ? ( 0 ) : ( _amount ) );    //  If the amount of ships removed is less than zero, set amount to 0
            #region Old code
            ////  Adds the amount of ships to the specific type, specefied by the ShipType enum
            //switch ( _type )
            //{
            //    case ShipType.SmallCargoShip:
            //        SmallCargoes -= _amount;
            //        break;
            //    case ShipType.LargeCargoShip:
            //        LargeCargoShips -= _amount;
            //        break;
            //    case ShipType.LightFighter:
            //        LightFighters -= _amount;
            //        break;
            //    case ShipType.HeavyFighter:
            //        HeavyFighters -= _amount;
            //        break;
            //    case ShipType.Cruiser:
            //        Cruisers -= _amount;
            //        break;
            //    case ShipType.Battleship:
            //        Battleships -= _amount;
            //        break;
            //    case ShipType.Battlecruiser:
            //        Battlecruisers -= _amount;
            //        break;
            //    case ShipType.Destroyer:
            //        Destroyers -= _amount;
            //        break;
            //    case ShipType.Deathstar:
            //        Deathstars -= _amount;
            //        break;
            //    case ShipType.Bomber:
            //        Bombers -= _amount;
            //        break;
            //    case ShipType.Recycler:
            //        Recyclers -= _amount;
            //        break;
            //    case ShipType.EspionageProbe:
            //        EspionageProbes -= _amount;
            //        break;
            //    case ShipType.ColonyShip:
            //        ColonyShips -= _amount;
            //        break;
            //    default:
            //        throw new KeyNotFoundException ( "Error in Fleet.Remove_Ship(ShipType, int) - invalid data in Switch (_type):  default" );
            //} 
            #endregion

            Ships [(int) _type] = _amount;
        }

        /// <summary>
        /// Convets the Fleet object into a formatted string printable in the console
        /// </summary>
        /// <returns></returns>
        public string Format_To_Console()
        {
            return $"Fleet: {Name}\n{{\n    Small Cargo Ships : {Ships [(int) ShipType.SmallCargoShip]}\n    Large Cargo Ships : {Ships [(int) ShipType.LargeCargoShip]}\n    Light Fighters    : {Ships [(int) ShipType.LightFighter]}\n    Heavy Fighters    : {Ships [(int) ShipType.HeavyFighter]}\n    Cruisers          : {Ships [(int) ShipType.Cruiser]}\n    Battleships       : {Ships [(int) ShipType.Battleship]}\n    Battlecruisers    : {Ships [(int) ShipType.Battlecruiser]}\n    Destroyers        : {Ships [(int) ShipType.Destroyer]}\n    Deathstars        : {Ships [(int) ShipType.Deathstar]}\n    Bombers           : {Ships [(int) ShipType.Bomber]}\n    Recyclers         : {Ships [(int) ShipType.Recycler]}\n    Espionage Probe   : {Ships [(int) ShipType.EspionageProbe]}\n    Colony Ships      : {Ships [(int) ShipType.ColonyShip]}";
        }

        public static Fleet operator +( Fleet _fleetA, Fleet _fleetB )
        {
            Fleet newFleet = new Fleet ( _fleetA.Name )
            {
                #region Old Code
                //SmallCargoes = _fleetA.SmallCargoes + _fleetB.SmallCargoes,
                //LargeCargoShips = _fleetA.LargeCargoShips + _fleetB.LargeCargoShips,
                //LightFighters = _fleetA.LightFighters + _fleetB.LightFighters,
                //HeavyFighters = _fleetA.HeavyFighters + _fleetB.HeavyFighters,
                //Cruisers = _fleetA.Cruisers + _fleetB.Cruisers,
                //Battleships = _fleetA.Battleships + _fleetB.Battleships,
                //Battlecruisers = _fleetA.Battlecruisers + _fleetB.Battlecruisers,
                //Destroyers = _fleetA.Destroyers + _fleetB.Destroyers,
                //Deathstars = _fleetA.Deathstars + _fleetB.Deathstars,
                //Bombers = _fleetA.Bombers + _fleetB.Bombers,
                //Recyclers = _fleetA.Recyclers + _fleetB.Recyclers,
                //EspionageProbes = _fleetA.EspionageProbes + _fleetB.EspionageProbes,
                //ColonyShips = _fleetA.ColonyShips + _fleetB.ColonyShips 
                #endregion

            };

            //  Add all ships together with their corresponding shiptype in each fleet
            for ( ShipType ship = 0; ship < ShipType.ColonyShip; ship++ )
            {
                newFleet.Add_ship ( ship, _fleetA.Ships [(int) ship] + _fleetB.Ships [(int) ship] );
            }

            return newFleet;
        }

        public static Fleet operator -( Fleet _fleetA, Fleet _fleetB )
        {
            Fleet newFleet = new Fleet ( _fleetA.Name );

            //  Subtract all ships from their corresponding shiptype in each fleet
            for ( ShipType ship = 0; ship < ShipType.ColonyShip; ship++ )
            {
                newFleet.Add_ship ( ship, _fleetA.Ships [(int) ship] - _fleetB.Ships [(int) ship] );
            }

            return newFleet;
        }
    }
}
