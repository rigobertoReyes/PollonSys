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
        
        private void preciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.precioDS);

        }

        private void Ajusteprecio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ivaDS.Iva' table. You can move, or remove it, as needed.
            this.ivaTableAdapter.Fill(this.ivaDS.Iva);
            // TODO: This line of code loads data into the 'productoDS.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            int valor =Convert.ToInt16( ivaTableAdapter.Getiva());
            numericUpDown1.Value = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajustes a = new Ajustes();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formeditarproducto f = new formeditarproducto();
            f.id= productoDS.Producto[productoBindingSource.Position].idProducto.ToString();
            f.nombre= productoDS.Producto[productoBindingSource.Position].nombreProducto.ToString();
            f.precio= productoDS.Producto[productoBindingSource.Position].precio.ToString();
            f.imagen= productoDS.Producto[productoBindingSource.Position].imagen.ToString();
            f.cantidad = productoDS.Producto[productoBindingSource.Position].cantidadEstante.ToString();
            f.Text = "Actualizar usuario";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            //if (idprodu != null)
            //{
            //    try
            //    {
            //        productoTableAdapter.Updateproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text),
            //           Convert.ToInt16(idprodu));
            //MessageBox.Show("Producto actualizado con exito");
            //this.productoTableAdapter.Fill(this.productoDS.Producto);
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Por favor ingrese los datos correctamente");
            //    }

            //}
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formeditarproducto f = new formeditarproducto();
            f.Text = "Agregar usuario";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.id = "No";
            f.ShowDialog();
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            //bool existe = false;

            //for (int i = 0; i < productoTableAdapter.Countproductos(); i++)
            //{
            //    if (nombreProductoTextBox.Text == productoDS.Producto[i].nombreProducto)
            //    {
            //        existe = true;
            //    }
            //}
            //if (existe == false)
            //{
            //    productoTableAdapter.Nuevoproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text));
            //    MessageBox.Show("Producto agregado exitosamente");
            //    this.productoTableAdapter.Fill(this.productoDS.Producto);
            //}
            //else
            //{
            //    MessageBox.Show("Error, ya hay un producto con el mismo nombre");
            //}
            
        }

       

        private void productoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ivaTableAdapter.Setiva(Convert.ToInt16(numericUpDown1.Value));
            MessageBox.Show("IVA actualizado con exito");
            int valor = Convert.ToInt16(ivaTableAdapter.Getiva());
            numericUpDown1.Value = valor;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (productoDS.Producto[productoBindingSource.Position].idProducto != 1)
            {
                MessageBox.Show("Se eliminara el Producto: " + productoDS.Producto[productoBindingSource.Position].nombreProducto);
                if (MessageBox.Show("Se eliminaran el producto anteriormente seleccionado. Esta seguro de que desea continuar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productoTableAdapter.Deletproducto(productoDS.Producto[productoBindingSource.Position].idProducto);
                    MessageBox.Show("Usuario eliminado con exito");
                    this.productoTableAdapter.Fill(this.productoDS.Producto);
                }
            }
            else
            {
                MessageBox.Show("El pollo no se puede eliminar");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productoTableAdapter.Buscarproducto(this.productoDS.Producto, Buscartxt.Text);
        }

     
    }
}
