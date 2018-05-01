using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataContainers.Structs
{
    /// <summary>
    /// Represents the cost of an object
    /// </summary>
    public struct Price
    {
        /// <summary>
        /// How much metal is to be used?
        /// </summary>
        public int MetalCost { get;}
        /// <summary>
        /// Hoe much Crystal is to be used?
        /// </summary>
        public int CrystalCost { get;}
        /// <summary>
        /// How much deuterium is to be used?
        /// </summary>
        public int DeuteriumCost { get;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_metal">The price in metal</param>
        /// <param name="_crystal">THe price in crystal</param>
        /// <param name="_deuterium">The price in deuterium</param>
        public Price( int _metal, int _crystal, int _deuterium )
        {
            MetalCost = _metal;
            CrystalCost = _crystal;
            DeuteriumCost = _deuterium;
        }

        /// <summary>
        /// Convets the Price object into a formatted string printable in the console
        /// </summary>
        /// <param name="_spacing">The amount of space between the cost values</param>
        /// <returns></returns>
        public string Format_To_Console( string _spacing )
        {
            return $"Metal     : {MetalCost}\n{_spacing}Crystal   : {CrystalCost}\n{_spacing}Deuterium : {DeuteriumCost}";
        }

        public static Price operator +( Price a, Price b )
        {
            Price newPrice = new Price ( a.MetalCost + b.MetalCost, a.CrystalCost + b.CrystalCost, a.DeuteriumCost + b.DeuteriumCost ); //  Add a and b together and create a new price object. Then return it

            return newPrice;
        }
    }
}
