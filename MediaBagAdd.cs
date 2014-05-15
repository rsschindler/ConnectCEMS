using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ConnectToCEMSDatabase
{
    public partial class MediaBagAdd : Form  // form for scanning MediaBag Assets
    {
        public static int count = 0;
        public MediaBagAdd()
        {
            InitializeComponent(); // Initialize and load form from MediaBagAdd.Designer.cs

            // SQL Database connection string which loads database for Stored Procedures
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=RAY-PC;Initial Catalog=CEMSDatabase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "SELECT MAX(ElectionLocation.LocationNumber) AS TotalLocations FROM ElectionLocation WHERE (ElectionID = 118)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            MessageBox.Show("Location Count: " + cmd.ExecuteScalar());
            string txtCount = cmd.ExecuteScalar().ToString();

        }

        #region ClickEvents  // Form Click event section

        private void txtElectionID_LostFocus(object sender, EventArgs e)  // check for valid ElectionID
        {
            int txtValue = int.Parse(txtElectionID.Text);
            if (txtValue > 110 && txtValue < 119)
            {
                if (txtElectionID.TextLength > 3)
                {
                    SendKeys.Send("{TAB}");
                }
            }
            else
            {
                MessageBox.Show("Not Valid ElectionID");
                SendKeys.Send("+{TAB}");
            }
        }


        private void txtLocationNumber_LostFocus(object sender, EventArgs e)  // checks for valid LocationNumber
        {   
            int value=0;
            while (value != 0) // check for 0 value entered
            {
                if (Int32.TryParse(txtLocationNumber.Text, out value))  // uses TryParse in a constructor 
                {
                    if (value > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Must Enter a value");
                    }
                }
            } // end while
        }

        private void txtMediaBagNumber_LostFocus(object sender, EventArgs e)  // checks for valid MediaBag Number
        {
            if (string.IsNullOrEmpty(txtMediaBagNumber.Text)) // Checks to see if field empty before allowing you to contiue
            {
                //SendKeys.Send("+{TAB}");  // Originally tried to send reverse tab key to goto previous field but creates endless loop
            }
            else
            {
                bool IsValidMediaNumber = true;
                while (IsValidMediaNumber)
                {
                    string txtInputMB = this.txtMediaBagNumber.Text.ToUpper();

                    switch (txtInputMB.Substring(0, 2))
                    {
                        case ("MB"):
                            txtMediaBagNumber.Text = txtInputMB.ToUpper();
                            IsValidMediaNumber = false;
                            break;
                        default:
                            MessageBox.Show("Message Box must be in this format: MB322-0001");
                            txtMediaBagNumber.Text = txtInputMB.ToUpper();
                            IsValidMediaNumber = false;
                            SendKeys.Send("+{TAB}");
                            break;
                    }
                }
            }
        }
        private void txtCellPhone_TextChanged(object sender, EventArgs e)  // checks for valid Cell Phone 
        {
            if (string.IsNullOrEmpty(txtCellPhone.Text)) // Checks to see if field empty before allowing you to contiue
            {
                //SendKeys.Send("+{TAB}");  // Originally tried to send reverse tab key to goto previous field but creates endless loop
            }
            else
            {
                bool IsValidCellPhone = true;
                while (IsValidCellPhone)
                {
                            string txtInputCP = this.txtCellPhone.Text.ToUpper();
                            IsValidCellPhone = false;

                    switch (txtInputCP.Substring(0, 2))
                    {
                        case ("CP"):
                            txtCellPhone.Text = txtInputCP.ToUpper();
                            break;
                        default:  // Message that pops up if incorrect data keyed or scanned and displays correct input parameters
                            MessageBox.Show("Message Box must be in this format: CP296-7553");
                            txtCellPhone.Text = txtInputCP.ToUpper();
                            IsValidCellPhone = false;
                            SendKeys.Send("+{TAB}");  // forces back to same field to correct entry
                            break;
                    } // end switch
                } // end while
            } // end if
        } // end private void txtCellPhone

        private void txtPalmPilot_TextChanged(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(txtPalmPilot.Text) && txtPalmPilot.TextLength > 4)
            {
                //SendKeys.Send("+{TAB}");  // Originally tried to send reverse tab key to goto previous field but creates endless loop
            }
            else
            {
                bool IsValidPalmPilot = true;
                while (IsValidPalmPilot)
                {
                    string txtInputPalm = this.txtPalmPilot.Text.ToUpper();
                    if (string.IsNullOrEmpty(txtPalmPilot.Text) || txtInputPalm.Length >4)
                    switch (txtInputPalm.Substring(0, 4))
                    {
                        case ("70U9"):
                            txtPalmPilot.Text = txtInputPalm.ToUpper();
                            IsValidPalmPilot = false;
                            break;
                        default:
                            MessageBox.Show("Message Box must be in this format: 70U9??????");
                            txtPalmPilot.Text = txtInputPalm.ToUpper();
                            IsValidPalmPilot = true;
                            SendKeys.Send("+{TAB}");
                            break;
                    } // end switch
                } // while 
            } // end if
            SendKeys.Send("{TAB}");
        } // end private void txtPalmPilot_TextChanged


        static void doIncrement(int doInput)
        {
            doInput++;
        }

        #endregion ClickEvents

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Save unless all fields have been authenticated");  // Used so database not modified and will add once CRUD functions added.
        }
    }
}
