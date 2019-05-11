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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }
        public string permiso = "Admin";
        private void Almacen_Load(object sender, EventArgs e)
        {
            if (permiso != "Admin")
            {
                button3.Visible = false;
            }
            // TODO: This line of code loads data into the 'perdidasDS.Perdidas' table. You can move, or remove it, as needed.
            this.perdidasTableAdapter.Fill(this.perdidasDS.Perdidas);
            
            // TODO: This line of code loads data into the 'loteDS.Lote' table. You can move, or remove it, as needed.
            this.loteTableAdapter.Fill(this.loteDS.Lote);
            

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Dispose();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void loteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loteDS);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Lote")
            {
                loteTableAdapter.Fill(this.loteDS.Lote);
            }
            else if (comboBox1.SelectedItem == "Condicion")
            {
                loteTableAdapter.FillByCondicion(this.loteDS.Lote);
            }
            else if (comboBox1.SelectedItem == "Estado de lote")
            {
                loteTableAdapter.FillByestadolote(this.loteDS.Lote);
            }
            else if (comboBox1.SelectedItem == "Fecha de llegada")
            {
                loteTableAdapter.FillByfechallegada(this.loteDS.Lote);
            }
            else if (comboBox1.SelectedItem == "Cantidad")
            {
                loteTableAdapter.FillBystock(this.loteDS.Lote);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Se eliminaran los pollos en stock del lote seleccionado. Esta seguro de que desea continuar?","Advertencia",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idlo = loteDS.Lote[loteBindingSource.Position].idLote;
                int cant = loteDS.Lote[loteBindingSource.Position].stock;
                DateTime dat = DateTime.Today;
                loteTableAdapter.EliminarLote(idlo);
                perdidasTableAdapter.newPerdida(Convert.ToString(dat), cant, "Cantidad restada del lote", idlo);
                MessageBox.Show("Lote eliminado del lote "+idlo);
                loteTableAdapter.Fill(this.loteDS.Lote);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoLote N = new NuevoLote();
            N.ShowDialog();
            loteTableAdapter.Fill(this.loteDS.Lote);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminarstockdialog d = new eliminarstockdialog();
            d.StartPosition = FormStartPosition.CenterScreen;
            d.Location = new Point(70,70);
            d.ShowDialog();
            int cant = d.sto;
            if (cant <= loteDS.Lote[loteBindingSource.Position].stock && cant != 0)
            {
                if (MessageBox.Show("Se eliminaran "+cant+" pollos del lote seleccionado. Esta seguro de que desea continuar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DateTime dat = DateTime.Today;
                    int idlot = loteDS.Lote[loteBindingSource.Position].idLote;
                    perdidasTableAdapter.newPerdida(Convert.ToString(dat), cant, "Cantidad restada del lote", idlot);
                    cant = loteDS.Lote[loteBindingSource.Position].stock - cant;
                    loteTableAdapter.Eliminarstock(cant, idlot);
                    
                    MessageBox.Show("Cantidad del lote eliminada del lote " + idlot);
                    loteTableAdapter.Fill(this.loteDS.Lote);    
                }
                
            }
            else if(cant != 0)
            {
                MessageBox.Show("Favor de ingresar una cantidad menor o igual a la del stock");
            }
        }
    }
}
