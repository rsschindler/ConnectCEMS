using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectToCEMSDatabase
{
    public partial class FormConnectToCEMSDatabase : Form
    {
        private string p;

        public FormConnectToCEMSDatabase()
        {
            InitializeComponent();
        }

        public FormConnectToCEMSDatabase(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

       
#region ClickEvents

        private void mnuUpdateElectionInfo_Click(object sender, EventArgs e)
        {
            try
            {
                    this.report_ElectionCardTableAdapter.Fill(this.electionCardDataSet.Report_ElectionCard, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtElectionID.Text, typeof(int))))));
                }

            catch (System.Exception ex)
            {
                if (txtElectionID.Text == null || txtElectionID.Text == "" )
                {
                    MessageBox.Show("You must enter an ElectionID e.g. 118");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void mnuFileScanEquipmentiVotronic_Click(object sender, EventArgs e)
        {
            DialogResult iResult = MessageBox.Show("Are you Ready to scan iVotronic?","Are You Ready",MessageBoxButtons.YesNo);
            switch (iResult)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    MessageBox.Show("Why Not?");
                    break;
            }
        }

        private void mnuFileScanEquipmentMediaBag_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are you Ready to scan Media Bags?","Are you ready to Scan?",MessageBoxButtons.YesNo);
            switch (dResult)
            {
                case DialogResult.Yes:
                    MediaBagScan form2 = new MediaBagScan();
                    form2.ShowDialog();
                       break;
                case DialogResult.No:
                    MessageBox.Show("Why Not?");
                    break;
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtElectionID_TextChanged(object sender, EventArgs e)
        {
            if (txtElectionID.Text == null || txtElectionID.Text == "")
            {
                MessageBox.Show("ElectionID cannot be blank, Please enter valid ElectionID");
            }
            else
            {
                this.report_ElectionCardTableAdapter.Fill(this.electionCardDataSet.Report_ElectionCard, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtElectionID.Text, typeof(int))))));
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Form is already open!  \n\nPlease enter valid ElectionID");
        }

#endregion ClickEvents

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileScanEquipmentMediaBagAdd_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are you Ready to Add Media Bags?", "Are you ready to Add?", MessageBoxButtons.YesNo);
            switch (dResult)
            {
                case DialogResult.Yes:
                    MediaBagAdd form2 = new MediaBagAdd();
                    form2.ShowDialog();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Why Not?");
                    break;
            }
        }


        internal IEnumerable<MediaBagAdd> ExecuteQuery<T1>(string p)
        {
            throw new NotImplementedException();
        }
    }
}
