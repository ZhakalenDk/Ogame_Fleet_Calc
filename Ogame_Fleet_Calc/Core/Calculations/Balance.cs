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
        private int [,] ships;

        #region Ships
        public int SC { get { return ships [0, 0]; } }
        public int LC { get { return ships [1, 0]; } }
        public int LF { get { return ships [2, 0]; } }
        public int HF { get { return ships [3, 0]; } }
        public int XX { get { return ships [4, 0]; } }
        public int BS { get { return ships [5, 0]; } }
        public int BC { get { return ships [6, 0]; } }
        public int DS { get { return ships [7, 0]; } }
        public int RIP { get { return ships [8, 0]; } }
        public int BB { get { return ships [9, 0]; } }
        public int RC { get { return ships [10, 0]; } }
        public int EP { get { return ships [11, 0]; } }
        public int CS { get { return ships [12, 0]; } }
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
            ships = new int [13, 2];
            ships [0, 0] = _SC;
            ships [1, 0] = _LC;
            ships [2, 0] = _LF;
            ships [3, 0] = _HF;
            ships [4, 0] = _XX;
            ships [5, 0] = _BS;
            ships [6, 0] = _BC;
            ships [7, 0] = _DS;
            ships [8, 0] = _RIP;
            ships [9, 0] = _BB;
            ships [12, 0] = _RC;
            ships [11, 0] = _EP;
            ships [12, 0] = _CS; 
            #endregion
        }

        /// <summary>
        /// Balancing fleet
        /// </summary>
        /// <param name="_fleet">The fleet to compare</param>
        /// <returns></returns>
        public Fleet Calculate_Balance( Fleet _fleet )
        {
            Fleet newFleet = new Fleet ( "Balanced Fleet" );
            ships [(int) ShipType.LightFighter, 1] = _fleet.LightFighters;

            ships [(int) ShipType.Cruiser, 1] = _fleet.LightFighters / ships [(int) ShipType.LightFighter, 0] * ships [(int) ShipType.Cruiser, 0];

            ships [(int) ShipType.Battleship, 1] = _fleet.Cruisers / ships [(int) ShipType.Cruiser, 0] * ships [(int) ShipType.Battleship, 0];

            Console.WriteLine ( $"Fighters = {ships [(int) ShipType.LightFighter, 1].ToString ( "0,000" )}\nCruisers = {ships [(int) ShipType.Cruiser, 1]}\nBattleships = {ships[(int)ShipType.Battleship, 1]}" );

            return newFleet;
        }
    }
}
