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
    public partial class Place : Form
    {
        public Place()
        {
            InitializeComponent();
        }

        private void placeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.placeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.verificationmiDataSet);

        }

        private void Place_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.verificationmiDataSet.place);

        }

        private void статусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.Show();
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
