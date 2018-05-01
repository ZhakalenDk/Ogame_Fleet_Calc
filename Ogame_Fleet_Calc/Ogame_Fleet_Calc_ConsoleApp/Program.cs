﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Classes;
using Core.DataContainers.Structs;
using Core.DataContainers.Enums;


namespace Ogame_Fleet_Calc_ConsoleApp
{
    class Program
    {
        static void Main( string [] args )
        {

            //IShip ship = new Ship ( ShipType.LightFighter, new Price ( 3000, 1000, 0 ) ); //  Testing constructor
            //IShip ship2 = new Ship ( ShipType.SmallCargoShip, new Price ( 2000, 2000, 0 ) );  //  Second test of constructor

            //Price combinedPrice = (Ship) ship + (Ship) ship2;   //  Testing adding two ships together

            //Price tenTimes = (Ship) ship * 10;   //  Testing multiplication of ships

            //Console.WriteLine ( $"{ship.Format_To_Console ()}\n\n{ship2.Format_To_Console ()}\n\nCombined Price:\n        {tenTimes.Format_To_Console ( "        " )}" );

            Fleet fleet = new Fleet ( "Alpha" );  //  Testing constructor
            fleet.Add_ship ( ShipType.LightFighter, 1500 ); //  Testing adding ship to fleet

            Fleet fleet2 = new Fleet ( "Beta" );    //  Testing constructor
            fleet2.Add_ship ( ShipType.SmallCargoShip, 2000 );  //  Testing adding ship to fleet

            Fleet fleet3 = fleet + fleet2;  //  Testing of adding two fleets together
            fleet3.Name = "Gamma";  //  Testing naming fleet
            fleet3.Add_ship ( ShipType.Cruiser, 150 ); //  Testing adding ship to fleet
            fleet3.Add_ship ( ShipType.Battleship, 75 ); //  Testing adding ship to fleet
            fleet3.Add_ship ( ShipType.Battlecruiser, 30 ); //  Testing adding ship to fleet
            fleet3.Add_ship ( ShipType.EspionageProbe, -400 );  //  Testing handling of negative integer values. Must result in zero

            fleet.Remove_Ship ( ShipType.LightFighter, 1500 );  //  Testing removal of ships from a fleet

            Console.WriteLine ( fleet.Format_To_Console () );
            Console.WriteLine ( fleet2.Format_To_Console () );
            Console.WriteLine ( fleet3.Format_To_Console () );

            Console.ReadKey ();
        }
    }
}
