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
    public partial class Ajusteprecio : Form
    {
        public Ajusteprecio()
        {
            InitializeComponent();
        }
        string idprodu = null;
        private void preciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.precioDS);

        }

        private void Ajusteprecio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productoDS.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (idprodu != null)
            {
                try
                {
                    productoTableAdapter.Updateproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text),
                       Convert.ToInt16(idprodu));
            MessageBox.Show("Producto actualizado con exito");
            this.productoTableAdapter.Fill(this.productoDS.Producto);
                }
                catch (Exception)
                {

                    MessageBox.Show("Por favor ingrese los datos correctamente");
                }

            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            if (ope.ShowDialog() == DialogResult.OK)
            {
                imagenTextBox.Text = ope.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool existe = false;

            for (int i = 0; i < productoTableAdapter.Countproductos(); i++)
            {
                if (nombreProductoTextBox.Text == productoDS.Producto[i].nombreProducto)
                {
                    existe = true;
                }
            }
            if (existe == false)
            {
                productoTableAdapter.Nuevoproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text));
                MessageBox.Show("Producto agregado exitosamente");
                this.productoTableAdapter.Fill(this.productoDS.Producto);
            }
            else
            {
                MessageBox.Show("Error, ya hay un producto con el mismo nombre");
            }
            
        }

       

        private void productoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idprodu = productoDS.Producto[productoBindingSource.Position].idProducto.ToString();
            nombreProductoTextBox.Text = productoDS.Producto[productoBindingSource.Position].nombreProducto.ToString();
            precioTextBox.Text = productoDS.Producto[productoBindingSource.Position].precio.ToString();
            imagenTextBox.Text = productoDS.Producto[productoBindingSource.Position].imagen.ToString();
            cantidadEstanteTextBox.Text = productoDS.Producto[productoBindingSource.Position].cantidadEstante.ToString();
        }
    }
}
