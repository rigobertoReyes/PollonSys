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
            
            formEdituser f = new formEdituser();
            f.Text = "Agregar nuevo usuario";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.id = "No";
            f.ShowDialog();
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEdituser f = new formEdituser();
            f.Text = "Actualizar usuario";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.id = usuarioDS.Usuario[usuarioBindingSource.Position].idUsuario.ToString();
            f.username = usuarioDS.Usuario[usuarioBindingSource.Position].Username;
            f.pass = usuarioDS.Usuario[usuarioBindingSource.Position].Password;
            f.nombre = usuarioDS.Usuario[usuarioBindingSource.Position].Nombre;
            f.tipo = usuarioDS.Usuario[usuarioBindingSource.Position].Tipo;
            f.ShowDialog();
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Se eliminara el usuario: " + usuarioDS.Usuario[usuarioBindingSource.Position].Nombre + "\nCon el nombre de usuario: "
                + usuarioDS.Usuario[usuarioBindingSource.Position].Username);
                if (MessageBox.Show("Se eliminaran el usuario anteriormente seleccionado. Esta seguro de que desea continuar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usuarioTableAdapter.DeleteUsuario(usuarioDS.Usuario[usuarioBindingSource.Position].idUsuario);
                    MessageBox.Show("Usuario eliminado con exito");
                    this.tableAdapterManager.UpdateAll(this.usuarioDS);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione un usuario");
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {


            
                usuarioTableAdapter.Buscaruser(this.usuarioDS.Usuario, Buscartxt.Text);
            
            
        }


     
    }
}
