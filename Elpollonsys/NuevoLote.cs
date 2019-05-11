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
    public partial class NuevoLote : Form
    {
        public NuevoLote()
        {
            InitializeComponent();
        }
        public int daysauxa,daysauxb;
        private void loteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loteDS);

        }

        private void NuevoLote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loteDS.Lote' table. You can move, or remove it, as needed.
            int i = 1;
            do
            {
                if (this.loteTableAdapter.Istherelote(i) == 1)
                {
                    comboBox1.Items.Add(i);
                }
                i++;
                
            } while (this.loteTableAdapter.Istherelote(i) == 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indica el lapso de dias que el pollo durara hasta llegar a un estado aceptable");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indica el lapso de dias que el pollo durara hasta llegar del estado aceptable al estado de caducado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int dias = Convert.ToInt16(numericUpDown1.Value);
            DateTime fecha =Convert.ToDateTime(fechaAceptableDateTimePicker.Text);
            daysauxa = dias - daysauxa;
            fecha = fecha.AddDays(daysauxa);
            fechaAceptableDateTimePicker.Text = Convert.ToString(fecha);
            daysauxa = dias;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int dias = Convert.ToInt16(numericUpDown2.Value);
            DateTime fecha = Convert.ToDateTime(fechaCaducidadDateTimePicker.Text);
            daysauxb = dias - daysauxb;
            fecha = fecha.AddDays(daysauxb);
            fechaCaducidadDateTimePicker.Text = Convert.ToString(fecha);
            daysauxb = dias;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadLoteTextBox.Text = Convert.ToString(this.loteTableAdapter.GetCantidadLote(Convert.ToInt16(comboBox1.SelectedItem)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || precioLoteTextBox.Text != "" || stockTextBox.Text != "" || stockTextBox.Text != "" || comboBox2.Text != "")
            {
                if (Convert.ToInt16(cantidadLoteTextBox.Text) >= Convert.ToInt16(stockTextBox.Text))
                {
                    this.loteTableAdapter.NuevoLote(Convert.ToInt16(precioLoteTextBox.Text), Convert.ToString(fechaLlegadaDateTimePicker.Text),
                    Convert.ToString(fechaAceptableDateTimePicker.Text), Convert.ToString(fechaCaducidadDateTimePicker.Text), Convert.ToInt16(stockTextBox.Text), "Aceptable", comboBox2.Text, Convert.ToInt16(comboBox1.Text));
                    MessageBox.Show("Datos Actualizados Correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cantidad indicada en stock supera a la capacidad del lote");
                }
                
            }
            else if (numericUpDown1.Value == 0 || numericUpDown2.Value==0)
            {
                MessageBox.Show("Por favor insterte valores validos para los dias aceptables o caducidad");
            }
            else if(comboBox1.Text == "")
            {
                MessageBox.Show("Por favor seleccione el id del lote para asignar el nuevo stock");
            }
            else
            {
                MessageBox.Show("Por favor complete los datos que faltan");
            }
        }

        
    }
}
