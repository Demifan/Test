using System;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class HCAddForm : Form
    {
        public HCAddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var hCarsForm = Owner as HeavyCars;

            if (hCarsForm != null)
            {
                var nRow = hCarsForm.testDataSet.Tables[1].NewRow();
                int rc = hCarsForm.HCDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = IdContractTextBox.Text;
                nRow[2] = NumberTextBox.Text;
                nRow[3] = BrandTextBox.Text;
                nRow[4] = LengthTextBox.Text;
                nRow[5] = WidthTextBox.Text;
                nRow[6] = HeighTextBox.Text;
                nRow[7] = YearManufactureTextBox.Text;
                nRow[8] = IdEngineTextBox.Text;
                nRow[9] = TypeTransmissionTextBox.Text;
                nRow[10] = NumberGearsTextBox.Text;
                nRow[11] = CarryingCapacityTextBox.Text;
                hCarsForm.testDataSet.Tables[1].Rows.Add(nRow);

                try
                {
                    hCarsForm.heavyCarsTableAdapter.Update(hCarsForm.testDataSet.HeavyCars);
                    hCarsForm.testDataSet.Tables[1].AcceptChanges();
                    hCarsForm.HCDataGridView.Refresh();
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("Введен несуществующий id контракта или двигателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                IdContractTextBox.Text = "";
                NumberTextBox.Text = "";
                BrandTextBox.Text = "";
                LengthTextBox.Text = "";
                WidthTextBox.Text = "";
                HeighTextBox.Text = "";
                YearManufactureTextBox.Text = "";
                IdEngineTextBox.Text = "";
                TypeTransmissionTextBox.Text = "";
                NumberGearsTextBox.Text = "";
                CarryingCapacityTextBox.Text = "";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
