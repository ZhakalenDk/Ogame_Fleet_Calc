using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DataContainers.Enums;

namespace UserInterfaceHandler_Library.SetParameters
{
    /// <summary>
    /// A class for setting the balance parameter values
    /// </summary>
    public class SetParameters
    {
        /// <summary>
        /// A global refrence. NOTE: SetParameters must be declared and initialized before using this refrence.
        /// </summary>
        public static SetParameters Instance
        {
            get
            {
                if ( Instance != null )
                {
                    return Instance;
                }
                else
                {
                    throw new NullReferenceException ();
                }
            }
            set
            {
                if ( Instance == null )
                {
                    Instance = value;
                }
            }
        }

        private ParameterBox [] parameters;

        /// <summary>
        /// The Constructor
        /// </summary>
        /// <param name="_parametersPanel"></param>
        public SetParameters ( ref FlowLayoutPanel _parametersPanel )
        {
            parameters = new ParameterBox [13];

            for ( ShipType type = 0; type <= ShipType.ColonyShip; type++ )
            {
                TextBox textBox = (TextBox) _parametersPanel.Controls [(int) type];
                ParameterBox newParameterbox = new ParameterBox ( type, ref textBox );
                Add_Parameterbox ( newParameterbox );
            }

        }

        /// <summary>
        /// Finds a specific parameterbox in the list and returns its textfield. NOTE: Will return null if the object is not found
        /// </summary>
        /// <param name="_type">The type to look for</param>
        /// <returns></returns>
        public TextBox Get_ParameterBox ( ShipType _type )
        {
            for ( ShipType item = 0; item <= ShipType.ColonyShip; item++ )
            {
                //  If the index position is null (There's no object) skip the position
                if ( parameters [(int) item] == null )
                {
                    continue;
                }
                // If the parameter-type matches the parameterbox-type return it
                if ( parameters [(int) item].Type == _type )
                {
                    return parameters [(int) item].TextField;
                }
            }

            return null;
        }

        /// <summary>
        /// Adds a parameterbox to the list
        /// </summary>
        /// <param name="_parameterBox"></param>
        public void Add_Parameterbox ( ParameterBox _parameterBox )
        {
            parameters [(int) _parameterBox.Type] = _parameterBox;
        }

        /// <summary>
        /// Removes a parameterbox from the list. NOTE: Will set the list value to "null"
        /// </summary>
        /// <param name="_parameterbox"></param>
        public void Remove_Parameterbox ( ParameterBox _parameterbox )
        {
            parameters [(int) _parameterbox.Type] = null;
        }
    }
}
