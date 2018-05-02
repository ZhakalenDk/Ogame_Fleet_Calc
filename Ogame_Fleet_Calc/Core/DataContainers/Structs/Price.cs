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
        public int MetalCost { get; }
        /// <summary>
        /// Hoe much Crystal is to be used?
        /// </summary>
        public int CrystalCost { get; }
        /// <summary>
        /// How much deuterium is to be used?
        /// </summary>
        public int DeuteriumCost { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_metal">The amount of metal the object costs</param>
        /// <param name="_crystal">The amount of crystal the object costs</param>
        /// <param name="_deuterium">The amount of deuterium the object costs</param>
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

        public static Price operator +( Price _priceA, Price _priceB )
        {
            Price newPrice = new Price ( _priceA.MetalCost + _priceB.MetalCost, _priceA.CrystalCost + _priceB.CrystalCost, _priceA.DeuteriumCost + _priceB.DeuteriumCost ); //  Add a and b together and create a new price object. Then return it

            return newPrice;
        }

        public static Price operator -( Price _priceA, Price _priceB )
        {
            Price newPrice = new Price ( _priceA.MetalCost - _priceB.MetalCost, _priceA.CrystalCost - _priceB.CrystalCost, _priceA.DeuteriumCost - _priceB.DeuteriumCost ); //  Subtract a and b and create  new price object. Then return it

            return newPrice;
        }
    }
}
