using ClientForDataBase.TestDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientForDataBase
{
    public partial class QCForm : Form
    {
        public QCForm()
        {
            InitializeComponent();
        }

        private void QCForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.QuantitativeComposition". При необходимости она может быть перемещена или удалена.
            this.quantitativeCompositionTableAdapter.Fill(this.testDataSet.QuantitativeComposition);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var quantitative = new QuantitativeCompositionTableAdapter();
            quantitative.Update(testDataSet);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var QCAddForm = new QCAddForm();
            QCAddForm.StartPosition = FormStartPosition.Manual;
            QCAddForm.Location = new Point(Left + 100, Top + 50);
            QCAddForm.Owner = this;
            QCAddForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
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
