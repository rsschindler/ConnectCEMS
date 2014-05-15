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
    public partial class MediaBagScan : Form
    {
        public MediaBagScan()
        {
            InitializeComponent();
        }


        private void txtElectionID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.report_MediaBagScanTableAdapter.Fill(this.mediaBagScanDataSet.Report_MediaBagScan, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtElectionID.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDataSet(DataSet dataSet)
        {
            if (!dataSet.HasChanges(DataRowState.Modified))
            {
                return;
            }
            DataSet tempDataSet = dataSet.GetChanges(DataRowState.Modified);
            if (tempDataSet.HasErrors)
            {
                MessageBox.Show("Data has Errors");
            }
            else
            {
                tableAdapterManager.UpdateAll(tempDataSet);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
