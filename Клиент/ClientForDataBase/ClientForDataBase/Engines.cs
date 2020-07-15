using ClientForDataBase.TestDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class Engines : Form
    {
        public Engines()
        {
            InitializeComponent();
        }

        private void Engines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Engines". При необходимости она может быть перемещена или удалена.
            this.enginesTableAdapter.Fill(this.testDataSet.Engines);

        }

        private void EDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var engine = new EnginesTableAdapter();
            engine.Update(testDataSet);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var enginesAddForm = new EnginesAddForm();
            enginesAddForm.StartPosition = FormStartPosition.Manual;
            enginesAddForm.Location = new Point(Left + 100, Top + 80);
            enginesAddForm.Owner = this;
            enginesAddForm.Show();
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

        private void LightCars_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new LightCars();
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
