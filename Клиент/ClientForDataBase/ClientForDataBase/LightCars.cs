using ClientForDataBase.TestDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClientForDataBase
{
    public partial class LightCars : Form
    {
        public LightCars()
        {
            InitializeComponent();
        }

        private void LightCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.LightCars". При необходимости она может быть перемещена или удалена.
            this.lightCarsTableAdapter.Fill(this.testDataSet.LightCars);

        }

        private void LCarsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var lightCars = new LightCarsTableAdapter();
            try
            {
                lightCars.Update(testDataSet);
            }
            catch (SqlException)
            {

                MessageBox.Show("Введен несуществующий id контракта или двигателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var lCarsAddForm = new LCAddForm();
            lCarsAddForm.StartPosition = FormStartPosition.Manual;
            lCarsAddForm.Location = new Point(Left + 100, Top + 80);
            lCarsAddForm.Owner = this;
            lCarsAddForm.Show();
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

        private void HeavyCars_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new HeavyCars();
            Program.Context.MainForm.StartPosition = FormStartPosition.Manual;
            Program.Context.MainForm.Location = Location;
            Close();
            Program.Context.MainForm.Show();
        }
    }
}
