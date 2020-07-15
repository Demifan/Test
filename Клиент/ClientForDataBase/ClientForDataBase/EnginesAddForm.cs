using System;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class EnginesAddForm : Form
    {
        public EnginesAddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var enginesForm = Owner as Engines;

            if (enginesForm != null)
            {
                var nRow = enginesForm.testDataSet.Tables[0].NewRow();
                int rc = enginesForm.EDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = TypeTextBox.Text;
                nRow[2] = PowerTextBox.Text;
                nRow[3] = VolumeTextBox.Text;
                enginesForm.testDataSet.Tables[0].Rows.Add(nRow);
                enginesForm.enginesTableAdapter.Update(enginesForm.testDataSet.Engines);
                enginesForm.testDataSet.Tables[0].AcceptChanges();
                enginesForm.EDataGridView.Refresh();
                TypeTextBox.Text = "";
                PowerTextBox.Text = "";
                VolumeTextBox.Text = "";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
