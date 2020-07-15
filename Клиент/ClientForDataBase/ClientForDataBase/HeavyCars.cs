using ClientForDataBase.TestDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class HeavyCars : Form
    {
        public HeavyCars()
        {
            InitializeComponent();
        }

        private void HeavyCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.HeavyCars". При необходимости она может быть перемещена или удалена.
            this.heavyCarsTableAdapter.Fill(this.testDataSet.HeavyCars);

        }

        private void HCDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var heavyCars = new HeavyCarsTableAdapter();
            try
            {
                heavyCars.Update(testDataSet);
            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Введен несуществующий id контракта или двигателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var hCarsAddForm = new HCAddForm();
            hCarsAddForm.StartPosition = FormStartPosition.Manual;
            hCarsAddForm.Location = new Point(Left + 100, Top + 80);
            hCarsAddForm.Owner = this;
            hCarsAddForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuantitativeComposition_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new QCForm();
            Program.Context.MainForm.StartPosition = FormStartPosition.Manual;
            Program.Context.MainForm.Location = Location;
            Close();
            Program.Context.MainForm.Show();
        }

        private void Engines_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new Engines();
            Program.Context.MainForm.StartPosition = FormStartPosition.Manual;
            Program.Context.MainForm.Location = Location;
            Close();
            Program.Context.MainForm.Show();
        }

        private void LightCars_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new LightCars();
            Program.Context.MainForm.StartPosition = FormStartPosition.Manual;
            Program.Context.MainForm.Location = Location;
            Close();
            Program.Context.MainForm.Show();
        }
    }
}
