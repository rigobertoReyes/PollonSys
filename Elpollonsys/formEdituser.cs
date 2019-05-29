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
    public partial class formEdituser : Form
    {
        public formEdituser()
        {
            InitializeComponent();
            
        }
        public string title = "";
        public string id = "No";
        public string username, tipo, pass,nombre;
        private void formEdituser_Load(object sender, EventArgs e)
        {
            if (id != "No")
            {
                comboBox1.Text = tipo;
                usernameTextBox.Text = username;
                passwordTextBox.Text = pass;
                nombreTextBox.Text = nombre;    
            }
            
            // TODO: This line of code loads data into the 'usuarioDS.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == "No")
            {
                 if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && nombreTextBox.Text != "" && comboBox1.Text != "")
                 {
                     usuarioTableAdapter.NuevoUsuario(usernameTextBox.Text, passwordTextBox.Text, nombreTextBox.Text, comboBox1.Text);
                     MessageBox.Show("Usuario agregado con exito");
                     this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
                     this.Close();
                 }
                 else
                 {
                     MessageBox.Show("Por favor complete los datos faltantes");
                 }
            }
            else
            {
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && nombreTextBox.Text != "" && comboBox1.Text != "")
                {
                    usuarioTableAdapter.UpdateUsuario(usernameTextBox.Text, passwordTextBox.Text, nombreTextBox.Text, comboBox1.Text, Convert.ToInt16(id));
                    MessageBox.Show("Usuario actualizado con exito");
                    this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor complete los datos faltantes");
                }
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarioDS);

        }
    }
}
