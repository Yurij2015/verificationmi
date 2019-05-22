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
    public partial class Specialist : Form
    {
        public Specialist()
        {
            InitializeComponent();
        }

        private void specialstBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialstBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.verificationmiDataSet);

        }

        private void Specialist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.specialst". При необходимости она может быть перемещена или удалена.
            this.specialstTableAdapter.Fill(this.verificationmiDataSet.specialst);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void хToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void статусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.Show();
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
    }
}
