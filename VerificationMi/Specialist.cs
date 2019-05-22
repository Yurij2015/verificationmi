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
    }
}
