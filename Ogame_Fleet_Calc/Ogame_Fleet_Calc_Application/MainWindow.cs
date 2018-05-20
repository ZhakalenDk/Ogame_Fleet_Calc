using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Classes;
using Core.DataContainers.Enums;
using Core.Calculations;
using UserInterfaceHandler_Library.SetParameters;
using Core.EventSystem;

namespace Ogame_Fleet_Calc_Application
{
    public partial class MainWindow : Form
    {
        public MainWindow ()
        {
            InitializeComponent ();
            Root_Ship_List ();
            SetParameters.Instance = new SetParameters ( ref SetParameters_Parameters_Panel );  //  Set up the Parameter-value fields list
        }

        /// <summary>
        /// Creates the list of rootships to chose from
        /// </summary>
        public void Root_Ship_List ()
        {
            for ( ShipType ship = 0; ship <= ShipType.ColonyShip; ship++ )
            {
                SetParamaters_RootShipSelection_CheckBox.Items.Add ( ShipCollection.ShipsInCollection [(int) ship].Name );
            }
        }

        /// <summary>
        /// When the text is changed inside a textbox
        /// </summary>
        /// <param name="_sender">The textbox</param>
        /// <param name="_e">The event</param>
        public void On_Text_Changed ( object _sender, EventArgs _e )
        {
            TextBox textBox = (TextBox) _sender;

            //  If the value of the textbox is not an integer replace it with a zero
            if ( !int.TryParse ( textBox.Text, out int value ) && textBox.Text != "" )
            {
                textBox.Text = "0";
            }

            //  if the value of the textbox is not empty proceed to create the balance object
            if ( textBox.Text != "" && SetParamaters_RootShipSelection_CheckBox.SelectedItems.Count != 0 )
            {

                #region Test Fleet values
                Fleet fleet = new Fleet ( "Test Fleet" );
                fleet.Add_ship ( ShipType.LightFighter, 500 );
                fleet.Add_ship ( ShipType.Cruiser, 500 );
                #endregion

                Fleet balance = new Balance ( int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.SmallCargoShip ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.LargeCargoShip ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.LightFighter ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.HeavyFighter ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Cruiser ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Battleship ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Battlecruiser ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Destroyer ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Deathstar ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Bomber ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.Recycler ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.EspionageProbe ).Text ), int.Parse ( SetParameters.Instance.Get_ParameterBox ( ShipType.ColonyShip ).Text ) ).Calculate_Balance ( fleet, (ShipType) SetParamaters_RootShipSelection_CheckBox.SelectedIndex );
                MessageBox.Show ( balance.Format_To_Console () );
            }
        }

        /// <summary>
        /// When the textbox has ben focused
        /// </summary>
        /// <param name="_sender">THe textbox</param>
        /// <param name="_e">THe event</param>
        public void On_Focus ( object _sender, EventArgs _e )
        {
            TextBox textBox = (TextBox) _sender;

            //  If the value of the textbox is 0 on focus empty the textbox
            if ( textBox.Text == "0" )
            {
                textBox.Text = "";
            }

        }

        /// <summary>
        /// When the textbox is no longer in focus
        /// </summary>
        /// <param name="_sender">THe textbox</param>
        /// <param name="_e">The event</param>
        public void On_Unfocus ( object _sender, EventArgs _e )
        {
            TextBox textbox = (TextBox) _sender;

            //  If the value of the textbox is less or equal to zero when unfocused replace the empty string with a zero
            if ( textbox.Text.Length <= 0 )
            {
                textbox.Text = "0";
            }

        }

        /// <summary>
        /// Checks an item and unchecks already checked items if there is any
        /// </summary>
        /// <param name="_sender">The checklistbox</param>
        /// <param name="_e">The event</param>
        public void On_Selection ( object _sender, EventArgs _e )
        {
            CheckedListBox checkBox = (CheckedListBox) _sender;

            //  Loop trough items list and unchecked any item that may be checked
            for ( ShipType item = 0; item < ShipType.ColonyShip; item++ )
            {
                if ( checkBox.GetItemCheckState ( (int) item ) == CheckState.Checked )
                {
                    checkBox.SetItemCheckState ( (int) item, CheckState.Unchecked );
                }
            }

            checkBox.SetItemCheckState ( checkBox.SelectedIndex, CheckState.Checked );  //  Check the current selected item
        }
    }
}
