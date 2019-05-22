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

    public partial class Measuringinstrument : Form
    {
        public Measuringinstrument()
        {
            InitializeComponent();
        }

        private void хToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void measuringinstrumentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.measuringinstrumentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.verificationmiDataSet);

        }

        private void Measuringinstrument_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.typeofmi". При необходимости она может быть перемещена или удалена.
            this.typeofmiTableAdapter.Fill(this.verificationmiDataSet.typeofmi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.verificationmiDataSet.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.verificationmiDataSet.place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.specialst". При необходимости она может быть перемещена или удалена.
            this.specialstTableAdapter.Fill(this.verificationmiDataSet.specialst);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "verificationmiDataSet.measuringinstrument". При необходимости она может быть перемещена или удалена.
            this.measuringinstrumentTableAdapter.Fill(this.verificationmiDataSet.measuringinstrument);

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

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
