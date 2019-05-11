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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void Login()
        {
            
                int c = Convert.ToInt16(usuarioTableAdapter.Login(textBox1.Text, textBox2.Text));
                if (c == 1)
                {
                    Program.nombredeusuario = Convert.ToString(usuarioTableAdapter.GetName(textBox1.Text));
                    string tipo = Convert.ToString(usuarioTableAdapter.GetType(textBox1.Text, textBox2.Text));
                    if (tipo == "Admin")
                    {
                        Menu m = new Menu();

                        m.Show();
                        this.Dispose();
                    }
                    else if (tipo == "Venta")
                    {
                        Venta v = new Venta();
                        v.permiso = "Venta";
                        v.Show();
                        this.Dispose();
                    }
                    else if (tipo == "Almacen")
                    {
                        Almacen a = new Almacen();
                        a.permiso = "Almacen";
                        a.Show();
                        this.Dispose();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos" + c);
                }

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            
            
        }
        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pollonDBDataSet);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pollonDBDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.pollonDBDataSet.Usuario);

        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
       