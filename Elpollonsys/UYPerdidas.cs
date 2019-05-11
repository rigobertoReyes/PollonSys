using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elpollonsys
{
    public partial class UYPerdidas : Form
    {
        public UYPerdidas()
        {
            InitializeComponent();
        }

        private void perdidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.perdidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perdidasDS);

        }

        private void UYPerdidas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perdidasDS.Perdidas' table. You can move, or remove it, as needed.
            this.perdidasTableAdapter.Fill(this.perdidasDS.Perdidas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Dispose();
        }
    }
}
