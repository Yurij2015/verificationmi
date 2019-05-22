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
    public partial class TypeOfMi : Form
    {
        public TypeOfMi()
        {
            InitializeComponent();
        }

        private void typeofmiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeofmiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.verificationmiDataSet);

        }

        private void TypeOfMi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.typeofmi". При необходимости она может быть перемещена или удалена.
            this.typeofmiTableAdapter.Fill(this.verificationmiDataSet.typeofmi);

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

        private void хToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
