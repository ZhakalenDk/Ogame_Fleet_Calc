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
    /// Represents a parameter value
    /// </summary>
    public class ParameterBox
    {
        /// <summary>
        /// Which type the parameterbox is associated with
        /// </summary>
        public ShipType Type { get;}
        /// <summary>
        /// The parameter textfield
        /// </summary>
        public TextBox TextField { get;}
        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="_type">The type the parameterbox is associated with</param>
        /// <param name="_textField">The textbox the parameter value is written in</param>
        public ParameterBox (ShipType _type, ref TextBox _textField )
        {
            Type = _type;
            TextField = _textField;
        }
    }
}
