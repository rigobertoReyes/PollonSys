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
    public partial class Ajusteusuario : Form
    {
        public Ajusteusuario()
        {
            InitializeComponent();
        }
        string id = "";
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarioDS);

        }

        private void Ajusteusuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usuarioDS.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajustes a = new Ajustes();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && nombreTextBox.Text != "" && comboBox1.Text != "")
            {
                usuarioTableAdapter.NuevoUsuario(usernameTextBox.Text, passwordTextBox.Text, nombreTextBox.Text, comboBox1.Text);
                MessageBox.Show("Usuario agregado con exito");
                this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            }
            else
            {
                MessageBox.Show("Por favor complete los datos faltantes");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && nombreTextBox.Text != "" && comboBox1.Text != "")
            {
                usuarioTableAdapter.UpdateUsuario(usernameTextBox.Text, passwordTextBox.Text, nombreTextBox.Text, comboBox1.Text, Convert.ToInt16(id));
                MessageBox.Show("Usuario actualizado con exito");
                this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            }
            else
            {
                MessageBox.Show("Por favor complete los datos faltantes");
            }
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBox1.Text = usuarioDS.Usuario[usuarioBindingSource.Position].Tipo;
            usernameTextBox.Text = usuarioDS.Usuario[usuarioBindingSource.Position].Username;
            passwordTextBox.Text = usuarioDS.Usuario[usuarioBindingSource.Position].Password;
            nombreTextBox.Text = usuarioDS.Usuario[usuarioBindingSource.Position].Nombre;
            id = usuarioDS.Usuario[usuarioBindingSource.Position].idUsuario.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && nombreTextBox.Text != "" && comboBox1.Text != "")
            {
                usuarioTableAdapter.DeleteUsuario(Convert.ToInt16(id));
                MessageBox.Show("Usuario eliminado con exito");
                this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            }
            else
            {
                MessageBox.Show("Por favor complete los datos faltantes");
            }
        }


     
    }
}
