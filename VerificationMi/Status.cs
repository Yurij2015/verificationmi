using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationMi
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.verificationmiDataSet);

        }

        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.verificationmiDataSet.status);

        }

        private void местаПроверкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Place pc = new Place();
            pc.Show();
        }

        private void проверяющиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specialist sp = new Specialist();
            sp.Show();
        }

        private void типыСИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfMi tof = new TypeOfMi();
            tof.Show();
        }

        private void хToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
