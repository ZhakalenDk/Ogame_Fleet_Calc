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
    struct Price
    {
        /// <summary>
        /// How much metal is to be used?
        /// </summary>
        int MetalCost { get; set; }
        /// <summary>
        /// Hoe much Crystal is to be used?
        /// </summary>
        int CrystalCost { get; set; }
        /// <summary>
        /// How much deuterium is to be used?
        /// </summary>
        int DeuteriumCost { get; set; }

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

        public static Price operator +( Price a, Price b )
        {
            Price newPrice = new Price ( a.MetalCost + b.MetalCost, a.CrystalCost + b.CrystalCost, a.DeuteriumCost + b.DeuteriumCost ); //  Add a and b together and create a new price object. Then return it

            return newPrice;
        }
    }
}
