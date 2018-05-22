using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceHandler_Library.SetParameters;

namespace UserInterfaceHandler_Library.SetParameters
{
    public static class ParameterCollection
    {
        private static Dictionary<string, SetParameters> parameters = new Dictionary<string, SetParameters> ();

        /// <summary>
        /// Add a parameter list to the collection
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_parameters"></param>
        public static void Add_Parameter_List ( string _name, SetParameters _parameters )
        {
            parameters.Add ( _name, _parameters );
        }

        /// <summary>
        /// Get a parameter list from the collection
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        public static SetParameters Get_Parameters ( string _name )
        {
            parameters.TryGetValue ( _name, out SetParameters list );
            return list;
        }

        /// <summary>
        /// Remove a parameter list from the collection
        /// </summary>
        /// <param name="_name"></param>
        public static void Remove_Parameter_List (string _name)
        {
            parameters.Remove ( _name );
        }
    }
}
