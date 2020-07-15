using System;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class LCAddForm : Form
    {
        public LCAddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var lCarsForm = Owner as LightCars;

            if (lCarsForm != null)
            {
                var nRow = lCarsForm.testDataSet.Tables[2].NewRow();
                int rc = lCarsForm.LCDataGridView.RowCount + 1;
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
                nRow[11] = BodyTypeTextBox.Text;
                nRow[12] = CapacityTextBox.Text;
                lCarsForm.testDataSet.Tables[2].Rows.Add(nRow);

                try
                {
                    lCarsForm.lightCarsTableAdapter.Update(lCarsForm.testDataSet.LightCars);
                    lCarsForm.testDataSet.Tables[2].AcceptChanges();
                    lCarsForm.LCDataGridView.Refresh();
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
                BodyTypeTextBox.Text = "";
                CapacityTextBox.Text = "";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
