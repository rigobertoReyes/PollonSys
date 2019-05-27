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
    public partial class UYPerdidas : Form
    {
        public UYPerdidas()
        {
            InitializeComponent();
        }

        private void perdidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.perdidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perdidasDS);

        }

        private void UYPerdidas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productoDS.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            // TODO: This line of code loads data into the 'usuarioDS.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
            // TODO: This line of code loads data into the 'utilidadesDS.Utilidades' table. You can move, or remove it, as needed.
            this.utilidadesTableAdapter.Fill(this.utilidadesDS.Utilidades);
            // TODO: This line of code loads data into the 'perdidasDS.Perdidas' table. You can move, or remove it, as needed.
            this.perdidasTableAdapter.Fill(this.perdidasDS.Perdidas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Dispose();
        }
        public void allgreen()
        {
            CPVtxt.BackColor = Color.LimeGreen;
            GTtxt.BackColor = Color.LimeGreen;
        }
        public void allwindow()
        {
            CPVtxt.BackColor = SystemColors.Window;
            GTtxt.BackColor = SystemColors.Window;
        }
        public void overall(int ca)
        {
            CPVtxt.Text = utilidadesTableAdapter.Overcantpollos(ca).ToString();
            GTtxt.Text = "$"+utilidadesTableAdapter.Overgananciatotal(ca).ToString();
        }
        public void overall2(string nam, int ca)
        {
            CPVtxt.Text = utilidadesTableAdapter.Overcantpollos2(ca, nam).ToString();
            GTtxt.Text = "$"+utilidadesTableAdapter.Overgananciatotal2(ca, nam).ToString();
        }
        public void overall3(string nam)
        {
            CPVtxt.Text = utilidadesTableAdapter.Overcantpollos3(nam).ToString();
            GTtxt.Text = utilidadesTableAdapter.Overgananciatotal3(nam).ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                this.utilidadesTableAdapter.Fill(this.utilidadesDS.Utilidades);
                allwindow();
            }
            if (comboBox1.Text == "Enero")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 1);
                allgreen();
                overall(1);
            }
            if (comboBox1.Text == "Febrero")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 2);
                allgreen();
                overall(2);
            }
            if (comboBox1.Text == "Marzo")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 3);
                allgreen();
                overall(3);
            }
            if (comboBox1.Text == "Abril")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 4);
                allgreen();
                overall(4);
            }
            if (comboBox1.Text == "Mayo")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 5);
                allgreen();
                overall(5);
            }
            if (comboBox1.Text == "Junio")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 6);
                allgreen();
                overall(6);
            }
            if (comboBox1.Text == "Julio")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 7);
                allgreen();
                overall(7);
            }
            if (comboBox1.Text == "Agosto")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 8);
                allgreen();
                overall(8);
            }
            if (comboBox1.Text == "Septiembre")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 9);
                allgreen();
                overall(9);
            }
            if (comboBox1.Text == "Octubre")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 10);
                allgreen();
                overall(10);
            }
            if (comboBox1.Text == "Noviembre")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 11);
                allgreen();
                overall(11);
            }
            if (comboBox1.Text == "Diciembre")
            {
                utilidadesTableAdapter.Fullmonthtable(this.utilidadesDS.Utilidades, 12);
                allgreen();
                overall(12);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                utilidadesTableAdapter.FillBySolovendedor(this.utilidadesDS.Utilidades, comboBox2.Text);
                allwindow();
                overall3(comboBox2.Text);
            }
            if (comboBox1.Text == "Enero")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 1, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 1);
            }
            if (comboBox1.Text == "Febrero")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 2, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 2);
            }
            if (comboBox1.Text == "Marzo")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 3, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 3);
            }
            if (comboBox1.Text == "Abril")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 4, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 4);
            }
            if (comboBox1.Text == "Mayo")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 5, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 5);
            }
            if (comboBox1.Text == "Junio")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 6, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 6);
            }
            if (comboBox1.Text == "Julio")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 7, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 7);
            }
            if (comboBox1.Text == "Agosto")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 8, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 8);
            }
            if (comboBox1.Text == "Septiembre")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 9, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 9);
            }
            if (comboBox1.Text == "Octubre")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 10, comboBox2.Text); ;
                allgreen();
                overall2(comboBox2.Text, 10);
            }
            if (comboBox1.Text == "Noviembre")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 11, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 11);
            }
            if (comboBox1.Text == "Diciembre")
            {
                utilidadesTableAdapter.FillByMesynombre(this.utilidadesDS.Utilidades, 12, comboBox2.Text);
                allgreen();
                overall2(comboBox2.Text, 12);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            utilidadesTableAdapter.FillBydate(this.utilidadesDS.Utilidades, dateTimePicker1.Text);
        }

        private void utilidadesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal pollosvendidos = utilidadesDS.Utilidades[utilidadesBindingSource.Position].cantidadPollos;
            decimal preciopollo = utilidadesDS.Utilidades[utilidadesBindingSource.Position].precio;
            decimal ganancia = pollosvendidos * preciopollo;
            GTtxt.Text = ganancia.ToString();
            CPVtxt.Text = pollosvendidos.ToString();
        }

        private void UYPerdidas_Click(object sender, EventArgs e)
        {
            this.utilidadesTableAdapter.Fill(this.utilidadesDS.Utilidades);
            this.perdidasTableAdapter.Fill(this.perdidasDS.Perdidas);
            allwindow();
            allwindow2();
        }


        public void allwindow2()
        {
            PTtxt.BackColor = SystemColors.Window;
            PPtxt.BackColor = SystemColors.Window;
            PNtxt.BackColor = SystemColors.Window;
        }
        public void allgreen2()
        {
            PTtxt.BackColor = Color.LimeGreen;
            PPtxt.BackColor = Color.LimeGreen;
            PNtxt.BackColor = Color.LimeGreen; 
        }
        public void overallperdidas(int ca)
        {
            int pollosneta =Convert.ToInt16( perdidasTableAdapter.getmonthpollosdesc(ca, "Cantidad restada del lote"));
            int pollostotal = Convert.ToInt16(perdidasTableAdapter.getmonthpollosdesc(ca, "Cantidad perdida del estante"));
            int pr = Convert.ToInt16(utilidadesTableAdapter.Getprecio("" + 2019 + "-" + ca + "-" + 15 + ""));
            //Cuantos lotes hay y sacar promedio de precio
            int cantlotes =Convert.ToInt16( loteTableAdapter.Cuantoslotes());
            decimal preciolote = 0;
            for (int i = 1; i < cantlotes; i++)
            {
                preciolote =+ Convert.ToInt16( loteTableAdapter.Getpreciolote(i));
            }
            preciolote = preciolote / cantlotes;
            decimal perdidaneta = pollosneta * preciolote;
            decimal perdidatotal = (preciolote + pr) * pollostotal;
        
            PPtxt.Text = perdidasTableAdapter.getmonthpollos(ca).ToString();
            PTtxt.Text = perdidatotal.ToString();
            PNtxt.Text = perdidaneta.ToString();

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                this.perdidasTableAdapter.Fill(this.perdidasDS.Perdidas);
                allwindow2();
            }
            if (comboBox3.Text == "Enero")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 1);
                allgreen2();
                overallperdidas(1);
                MessageBox.Show("");
            }
            if (comboBox3.Text == "Febrero")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 2);
                allgreen2();
                overallperdidas(2);
            }
            if (comboBox3.Text == "Marzo")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 3);
                allgreen2();
                overallperdidas(3);
            }
            if (comboBox3.Text == "Abril")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 4);
                allgreen2();
                overallperdidas(4);
            }
            if (comboBox3.Text == "Mayo")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 5);
                allgreen2();
                overallperdidas(5);
            }
            if (comboBox3.Text == "Junio")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 6);
                allgreen2();
                overallperdidas(6);
            }
            if (comboBox3.Text == "Julio")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 7);
                allgreen2();
                overallperdidas(7);
            }
            if (comboBox3.Text == "Agosto")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 8);
                allgreen2();
                overallperdidas(8);
            }
            if (comboBox3.Text == "Septiembre")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 9);
                allgreen2();
                overallperdidas(9);
            }
            if (comboBox3.Text == "Octubre")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 10);
                allgreen2();
                overallperdidas(10);
            }
            if (comboBox3.Text == "Noviembre")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 11);
                allgreen2();
                overallperdidas(11);
            }
            if (comboBox3.Text == "Diciembre")
            {
                perdidasTableAdapter.Fullmonthtable(this.perdidasDS.Perdidas, 12);
                allgreen2();
                overallperdidas(12);
            }
        }

        private void perdidasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idlote = perdidasDS.Perdidas[perdidasBindingSource.Position].idLote;
            int preciolote =Convert.ToInt16( loteTableAdapter.Getpreciolote(idlote));
            int cantidadpolos = (perdidasDS.Perdidas[perdidasBindingSource.Position].cantidad);
            DateTime fec = perdidasDS.Perdidas[perdidasBindingSource.Position].fechaPerdida;
            int dia = fec.Day;
            int mes = fec.Month;
            int yea = fec.Year;

            if (perdidasDS.Perdidas[perdidasBindingSource.Position].descripcion == "Cantidad restada del lote")
            {
                int perdidaneta = cantidadpolos * preciolote;
                PNtxt.Text = perdidaneta.ToString();
                PTtxt.Text = "-";
            }
            else if (perdidasDS.Perdidas[perdidasBindingSource.Position].descripcion == "Cantidad perdida del estante" )
            {
                int pr=Convert.ToInt16( utilidadesTableAdapter.Getprecio(""+yea+"-"+mes+"-"+dia+""));
                int perdidatotal = (preciolote + pr) * cantidadpolos;
                PTtxt.Text = perdidatotal.ToString();
                PNtxt.Text = "-";
            }
            PPtxt.Text = cantidadpolos.ToString();
            


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            perdidasTableAdapter.FillByfecha(this.perdidasDS.Perdidas,dateTimePicker2.Text);
        }


       
    }
}
