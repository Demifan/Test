using System;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class QCAddForm : Form
    {
        public QCAddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var quantitativeCompositionForm = Owner as QCForm;

            if (quantitativeCompositionForm != null)
            {
                var nRow = quantitativeCompositionForm.testDataSet.Tables[3].NewRow();
                int rc = quantitativeCompositionForm.QCdataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NumberContractTextBox.Text;
                nRow[2] = DateContractTextBox.Text;
                nRow[3] = DatePurchaseTextBox.Text;
                quantitativeCompositionForm.testDataSet.Tables[3].Rows.Add(nRow);
                quantitativeCompositionForm.quantitativeCompositionTableAdapter.Update(quantitativeCompositionForm.testDataSet.QuantitativeComposition);
                quantitativeCompositionForm.testDataSet.Tables[3].AcceptChanges();
                quantitativeCompositionForm.QCdataGridView.Refresh();
                NumberContractTextBox.Text = "";
                DateContractTextBox.Text = "";
                DatePurchaseTextBox.Text = "";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
