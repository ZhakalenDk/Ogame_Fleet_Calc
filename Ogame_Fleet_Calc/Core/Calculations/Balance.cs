using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Classes;
using Core.DataContainers.Enums;

namespace Core.Calculations
{
    public class Balance
    {
        /// <summary>
        /// An array containing [Balance Scale, Amount Of Ships]
        /// </summary>
        private int [] ships;

        #region Ships
        public int SC { get { return ships [0]; } }
        public int LC { get { return ships [1]; } }
        public int LF { get { return ships [2]; } }
        public int HF { get { return ships [3]; } }
        public int XX { get { return ships [4]; } }
        public int BS { get { return ships [5]; } }
        public int BC { get { return ships [6]; } }
        public int DS { get { return ships [7]; } }
        public int RIP { get { return ships [8]; } }
        public int BB { get { return ships [9]; } }
        public int RC { get { return ships [10]; } }
        public int EP { get { return ships [11]; } }
        public int CS { get { return ships [12]; } }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_SC">Small Carco Ships</param>
        /// <param name="_LC">Large Cargo Ships</param>
        /// <param name="_LF">Light Fighters</param>
        /// <param name="_HF">Heavy Fighters</param>
        /// <param name="_XX">Cruisers</param>
        /// <param name="_BS">Battleships</param>
        /// <param name="_BC">Battlecruises</param>
        /// <param name="_DS">Destroyers</param>
        /// <param name="_BB">Bombers</param>
        /// <param name="_RC">Recyclers</param>
        /// <param name="_EP">Espionage Probes</param>
        /// <param name="_CS">Colony Ships</param>
        public Balance( int _SC, int _LC, int _LF, int _HF, int _XX, int _BS, int _BC, int _DS, int _RIP, int _BB, int _RC, int _EP, int _CS )
        {
            #region Adding values to array
            ships = new int [13];
            ships [0] = _SC;
            ships [1] = _LC;
            ships [2] = _LF;
            ships [3] = _HF;
            ships [4] = _XX;
            ships [5] = _BS;
            ships [6] = _BC;
            ships [7] = _DS;
            ships [8] = _RIP;
            ships [9] = _BB;
            ships [10] = _RC;
            ships [11] = _EP;
            ships [12] = _CS;
            #endregion
        }

        /// <summary>
        /// Calculate a balanced fleet based on the root shiptype scale
        /// </summary>
        /// <param name="_fleet">THe unbalanced fleet</param>
        /// <param name="_rootShip">The shiptype to base the balance scale on</param>
        /// <returns></returns>
        public Fleet Calculate_Balance( Fleet _fleet, ShipType _rootShip )
        {
            Fleet newFleet = new Fleet ( "Balanced Fleet" );

            newFleet = Calculate_Scale ( _fleet, _rootShip );

            //newFleet.Name = "DEBUG";
            //Console.WriteLine ( newFleet.Format_To_Console () );
            //newFleet.Name = "Balanced FLeet";

            newFleet = Restore_Root_Type ( newFleet, _fleet, _rootShip );

            newFleet = Calculate_Scale ( newFleet, _rootShip );
            //newFleet.Name = "DEBUG 2";
            //Console.WriteLine ( newFleet.Format_To_Console () );
            //newFleet.Name = "Balanced Fleet";

            return newFleet;
        }

        /// <summary>
        /// Calculates the balance scale of a fleet
        /// </summary>
        /// <param name="_fleet">The unbalanced fleet</param>
        /// <param name="_rootShip">The shiptype to base the scale on</param>
        /// <returns></returns>
        private Fleet Calculate_Scale( Fleet _fleet, ShipType _rootShip )
        {
            int rootShip = _fleet.Ships [(int) _rootShip];  //  Set the root shiptype amount
            //Console.WriteLine ( rootShip );

            Fleet newFleet = new Fleet ( "Balanced Fleet" );

            //  Add all ships to the fleet
            for ( ShipType ship = 0; ship <= ShipType.ColonyShip; ship++ )
            {
                //  If the balance scale of the current ship type is 0, Skip this block.
                if ( ships [(int) ship] != 0 )
                {
                    //Console.WriteLine ( $"[{ship.ToString()}] = {(rootShip / ships [(int) _rootShip] * ships[(int)ship]).ToString()}" );
                    newFleet.Add_ship ( ship, ( rootShip / ships [(int) _rootShip] * ships [(int) ship] ) );  //  Add balanced amount of the shiptype to the fleet
                }
            }

            return newFleet;
        }

        /// <summary>
        /// Sets a new base for the root shiptype of the unbalanced fleet
        /// </summary>
        /// <param name="_fleetA">The balanced fleet</param>
        /// <param name="_fleetB">The unbalanced fleet</param>
        /// <param name="_rootShip">The shiptype to base the scale on</param>
        /// <returns></returns>
        private Fleet Restore_Root_Type( Fleet _fleetA, Fleet _fleetB, ShipType _rootShip )
        {
            Fleet difference = _fleetA - _fleetB;   //  Find the difference between the balanced and unbalanced fleet
            //difference.Name = "Difference";
            //Console.WriteLine ( difference.Format_To_Console () );


            //  Loops trough all ships in the fleet to locate any negative values
            for ( ShipType ship = 0; ship <= ShipType.ColonyShip; ship++ )
            {
                //  If the amount of a shipstype is negative 
                if ( difference.Ships [(int) ship] < 0 )
                {
                    int result = ( difference.Ships [(int) ship] * ( -1 ) ) / ships [(int) ship] * ships [(int) _rootShip]; //  Calculate how many ships of the root type is needed to balance the negative value out
                    _fleetA.Add_ship ( _rootShip, result );

                }
            }

            return _fleetA;
        }
    }
}
