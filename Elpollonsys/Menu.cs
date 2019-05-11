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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public string a;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pollonDBDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'pollonDBDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.pollonDBDataSet.Usuario);
            label1.Text = "Bienvenido "+Program.nombredeusuario;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Almacen a = new Almacen();
            a.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestion g = new Gestion();
            g.Show();
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UYPerdidas u = new UYPerdidas();
            u.Show();
            this.Dispose();
        }
    }
}
