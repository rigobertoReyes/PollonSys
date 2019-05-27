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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void gestionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionDS);

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionDS.Gestion' table. You can move, or remove it, as needed.
            this.gestionTableAdapter.Fill(this.gestionDS.Gestion);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gestionTableAdapter.fulldate(this.gestionDS.Gestion, dateTimePicker1.Text);
            allwindow();
        }

        private void gestionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int pollofresco = gestionDS.Gestion[gestionBindingSource.Position].Pollosfrescos;
            //int polloaceptable = gestionDS.Gestion[gestionBindingSource.Position].Pollosaceptables;
            //int pollocaducado = gestionDS.Gestion[gestionBindingSource.Position].Polloscaducados;
            //int pollovendido = gestionDS.Gestion[gestionBindingSource.Position].Pollosvendidos;
            //int pollototal = polloaceptable + pollocaducado + pollofresco;
            //double IPP = pollocaducado / pollototal;
            //double IPV = pollocaducado / pollovendido;
            //MessageBox.Show(pollocaducado+"/"+pollototal+ "="+ IPP + "    " + IPV);
            //PFtxt.Text = pollofresco.ToString();
            //PTAtxt.Text = pollototal.ToString();
            //PAtxt.Text = polloaceptable.ToString();
            //PCtxt.Text = pollocaducado.ToString();
            //PVtxt.Text = pollovendido.ToString();
            //IPPtxt.Text = IPP.ToString();
            //IPVtxt.Text = IPV.ToString();
        }

        private void gestionDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            allwindow();
            decimal pollofresco = gestionDS.Gestion[gestionBindingSource.Position].Pollosfrescos;
            decimal polloaceptable = gestionDS.Gestion[gestionBindingSource.Position].Pollosaceptables;
            decimal pollocaducado = gestionDS.Gestion[gestionBindingSource.Position].Polloscaducados;
            int pollovendido = gestionDS.Gestion[gestionBindingSource.Position].Pollosvendidos;
            decimal pollototal = polloaceptable + pollocaducado + pollofresco;
            decimal IPP = pollocaducado / pollototal;
            decimal IPV = pollovendido / pollototal;
            //MessageBox.Show(pollocaducado + "/" + pollototal + "=" + IPP + "    " + IPV);
            PFtxt.Text = pollofresco.ToString();
            PTAtxt.Text = pollototal.ToString();
            PAtxt.Text = polloaceptable.ToString();
            PCtxt.Text = pollocaducado.ToString();
            PVtxt.Text = pollovendido.ToString();
            IPPtxt.Text = IPP.ToString();
            IPVtxt.Text = IPV.ToString();
        }

        private void Gestion_Click(object sender, EventArgs e)
        {
            this.gestionTableAdapter.Fill(this.gestionDS.Gestion);
            allwindow();
        }

     
        public void allgreen()
        {
            PFtxt.BackColor = Color.LightGreen; 
            PTAtxt.BackColor = Color.LightGreen; 
            PAtxt.BackColor = Color.LightGreen; 
            PCtxt.BackColor = Color.LightGreen; 
            PVtxt.BackColor = Color.LightGreen; 
            IPPtxt.BackColor = Color.LightGreen;
            IPVtxt.BackColor = Color.LightGreen;
            groupBox1.Text = "Por mes";
        }
        public void allwindow() 
        {
            PFtxt.BackColor = SystemColors.Window;
            PTAtxt.BackColor = SystemColors.Window;
            PAtxt.BackColor = SystemColors.Window;
            PCtxt.BackColor = SystemColors.Window;
            PVtxt.BackColor = SystemColors.Window;
            IPPtxt.BackColor = SystemColors.Window;
            IPVtxt.BackColor = SystemColors.Window;
            groupBox1.Text = "Por dia";
        }
        public void overall(int cadena)
        {
            decimal pollofresco = Convert.ToDecimal(gestionTableAdapter.Overpollosfrescos(cadena));
            decimal polloaceptable = Convert.ToDecimal(gestionTableAdapter.Overpollosaceptables(cadena));
            decimal pollocaducado = Convert.ToDecimal(gestionTableAdapter.Overpolloscaducados(cadena));
            int pollovendido = Convert.ToInt16(gestionTableAdapter.Overvendidos(cadena));
            decimal pollototal = polloaceptable + pollocaducado + pollofresco;
            decimal IPP = pollocaducado / pollototal;
            decimal IPV = pollovendido / pollototal;
            PFtxt.Text = pollofresco.ToString();
            PTAtxt.Text = pollototal.ToString();
            PAtxt.Text = polloaceptable.ToString();
            PCtxt.Text = pollocaducado.ToString();
            PVtxt.Text = pollovendido.ToString();
            IPPtxt.Text = IPP.ToString();
            IPVtxt.Text = IPV.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            allgreen();
            if (comboBox1.Text == "")
            {
                this.gestionTableAdapter.Fill(this.gestionDS.Gestion);
                allwindow();
            }
            if (comboBox1.Text == "Enero")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 1);
                allgreen();
                overall(1);
            }
            if (comboBox1.Text == "Febrero")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 2);
                allgreen();
            }
            if (comboBox1.Text == "Marzo")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 3);
                allgreen();
            }
            if (comboBox1.Text == "Abril")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 4);
                allgreen();
            }
            if (comboBox1.Text == "Mayo")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 5);
                allgreen();
            }
            if (comboBox1.Text == "Junio")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 6);
                allgreen();
            }
            if (comboBox1.Text == "Julio")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 7);
                allgreen();
            }
            if (comboBox1.Text == "Agosto")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 8);
                allgreen();
            }
            if (comboBox1.Text == "Septiembre")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 9);
                allgreen();
            }
            if (comboBox1.Text == "Octubre")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 10);
                allgreen();
            }
            if (comboBox1.Text == "Noviembre")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 11);
                allgreen();
            }
            if (comboBox1.Text == "Diciembre")
            {
                gestionTableAdapter.Fullmonthtable(this.gestionDS.Gestion, 12);
                allgreen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Dispose();
        }
    }
}

