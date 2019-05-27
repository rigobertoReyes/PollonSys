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
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajusteprecio a = new Ajusteprecio();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            m.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajusteusuario a = new Ajusteusuario();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
            this.Dispose();
        }
    }
}
