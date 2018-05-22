using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataContainers.Enums;

namespace Core.Classes
{
    /// <summary>
    /// Contains a collection of available ships
    /// </summary>
    public static class ShipCollection
    {
        private static Ship [] shipsInCollection;
        /// <summary>
        /// An array containing all ships that is currently in the collection
        /// </summary>
        public static Ship [] ShipsInCollection { get { if ( shipsInCollection == null ) { Initialize (); } return shipsInCollection; } private set { shipsInCollection = value; } }

        /// <summary>
        /// Initializes the array
        /// </summary>
        private static void Initialize()
        {
            shipsInCollection = Create_Ships ();
        }

        /// <summary>
        /// Creates the ships
        /// </summary>
        /// <returns></returns>
        private static Ship [] Create_Ships()
        {
            Ship [] ships = new Ship [13];  //  Initialize the array

            string [] fileStrings = Read_File ();

            //  Create each ship with data from the data file
            for ( ShipType ship = 0; ship <= ShipType.ColonyShip; ship++ )
            {
                string [] data = Get_Data ( fileStrings [(int) ship], '-' );    //  Get data

                int.TryParse ( data [0], out int metal );
                int.TryParse ( data [1], out int crystal );
                int.TryParse ( data [2], out int deuterium );

                Ship newShip = new Ship ( ship, new DataContainers.Structs.Price ( metal, crystal, deuterium)); //  Create ship
                ships [(int) ship] = newShip;   //  Store the new ship in the array
            }

            return ships;
        }

        /// <summary>
        /// Converts the raw data from a single line into useable data.
        /// Data can not exceed more than 2 seperations determined by the seperator symbol. EXAMPLE: I'm-a-string = [I'm][a][string]
        /// </summary>
        /// <example>"I'm-a-method"</example>
        /// <param name="_rawData">The raw data from file</param>
        /// /// <param name="_seperator">The symbol to look for as speration points</param>
        /// <returns></returns>
        private static string [] Get_Data( string _rawData, char _seperator)
        {
            string [] data = new string [3];    //  Container for storing the data
            data = _rawData.Split ( _seperator );   //  Splitting the raw data string into 3 strings
            //Console.WriteLine ( $"{data[0]} - {data [1]} - {data [2]}");
            return data;
        }

        /// <summary>
        /// Reads the content of a file and returns it as a string
        /// </summary>
        /// <returns></returns>
        private static string [] Read_File()
        {
            string path = System.IO.Path.GetFullPath ( "RawData/Ship_Collection.ini" ); //  path to the .ini file
            //Console.WriteLine ( path );
            return System.IO.File.ReadAllLines ( @path );   //  Read and return the file content
        }
    }
}
