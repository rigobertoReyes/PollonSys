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
    public partial class formeditarproducto : Form
    {
        public formeditarproducto()
        {
            InitializeComponent();
        }
        public string id = "No";
        public string nombre, precio, imagen, cantidad;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id != "No")
            {
                if (id != null)
                {
                    try
                    {
                        productoTableAdapter.Updateproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text),
                           Convert.ToInt16(id));
                        MessageBox.Show("Producto actualizado con exito");
                        this.productoTableAdapter.Fill(this.productoDS.Producto);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Por favor ingrese los datos correctamente");
                    }
                }
                else
                {
                    bool existe = false;

                    for (int i = 0; i < productoTableAdapter.Countproductos(); i++)
                    {
                        if (nombreProductoTextBox.Text == productoDS.Producto[i].nombreProducto)
                        {
                            existe = true;
                        }
                    }
                    if (existe == false && nombreProductoTextBox.Text != "" && precioTextBox.Text != "" && imagenTextBox.Text != "" && cantidadEstanteTextBox.Text != "")
                    {
                        productoTableAdapter.Nuevoproducto(nombreProductoTextBox.Text, Convert.ToInt16(precioTextBox.Text), imagenTextBox.Text, Convert.ToInt16(cantidadEstanteTextBox.Text));
                        MessageBox.Show("Producto agregado exitosamente");
                        this.productoTableAdapter.Fill(this.productoDS.Producto);
                    }
                    else if (existe == true)
                    {
                        MessageBox.Show("Error, ya hay un producto con el mismo nombre");
                    }
                    else
                    {
                        MessageBox.Show("Por favor inserte los datos faltantes");
                    }
                }
            }
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productoDS);

        }

        private void formeditarproducto_Load(object sender, EventArgs e)
        {
            if (id == "1")
            {
                nombreProductoTextBox.Enabled = false;
            }
            nombreProductoTextBox.Text = nombre;
            precioTextBox.Text = precio;
            imagenTextBox.Text = imagen;
            cantidadEstanteTextBox.Text = cantidad;
            // TODO: This line of code loads data into the 'productoDS.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.productoDS.Producto);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            if (ope.ShowDialog() == DialogResult.OK)
            {
                imagenTextBox.Text = ope.FileName;
            }
        }
    }
}
