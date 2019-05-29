using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Elpollonsys
{
    public partial class Venta : Form
    {
        Button[,] boton = new Button[100, 4];
        Label[,] label = new Label[100, 4];
        public Venta()
        {

            InitializeComponent();
            label1.Text = "Vendedor: " + Program.nombredeusuario;
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            
            int k = 0;
            int uh = 0;
            uh = Convert.ToInt16(productoTableAdapter.Countproductos());
            int[,] coori = new int[uh, 4];
            int[,] coorj = new int[uh, 4];            
            
            for (int i = 0; k < uh; i++)
            {
                for (int j = 0; j < 4 && k < uh; j++)
                {
                    coori[i, j] = i;
                    coorj[i, j] = j;
                    boton[i, j] = new Button();
                    label[i, j] = new Label();
                    boton[i, j].Width = 142;
                    boton[i, j].Height = 124;
                    label[i, j].Width = 142;
                    boton[i, j].Tag = productoDS.Producto[k].precio.ToString();
                    boton[i, j].Text = "0";
                    boton[i, j].ForeColor= Color.Lime;
                    label[i, j].ForeColor = Color.White;
                    boton[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 15f,FontStyle.Bold);
                    label[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    boton[i, j].Name = productoDS.Producto[k].nombreProducto.ToString();
                    boton[i, j].BackgroundImage = System.Drawing.Image.FromFile(productoDS.Producto[k].imagen);
                    boton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    boton[i, j].Top = i * 162;
                    boton[i, j].Left = j * 150;
                    label[i, j].Text = productoDS.Producto[k].nombreProducto.ToString() +": $"+productoDS.Producto[k].precio.ToString();
                    //MessageBox.Show(label[i, j].Text);
                    label[i, j].Top = (i*162)+130;
                    label[i, j].Left = j *150;
                    boton[i, j].Click += delegate(object sender2, EventArgs e2)
                    {
                        Venta_Click(sender2, e2,boton);
                    };
                    this.panel1.Controls.Add(boton[i, j]);
                    this.panel1.Controls.Add(label[i, j]);
                    k++;
                }
            }
        }
        
        decimal totalventa = 0;
        decimal iva;
        decimal subtotal = 0;
        string[,] indiceboton = new string[100,4];
        public void Venta_Click(object sender, EventArgs e,Button[,] boton)
        {
            Button bt = (Button)sender;
            int ii = 0;
            int ij = 0;
            for (int i = 0; i < boton.GetLength(0); i++)
            {
                for (int j = 0; j < boton.GetLength(1); j++)
                {
                    if (bt == boton[i,j])
                    {
                        ii = i;
                        ij = j;
                    }
                }
            }
            int carrito = Convert.ToInt16(bt.Text);
            if (listBox1.Items.Count == 0)
            {
                
                carrito++;
                bt.Text = carrito.ToString();
                listBox1.Items.Add("" + bt.Name + " :$"+bt.Tag+"   X" + bt.Text);
                
                subtotal += Convert.ToInt16(bt.Tag);
                totalventa = subtotal * (1 + iva);
                subtotallabel.Text = "Subtotal: $" + subtotal;
                ventaLabel.Text = "Total: $" + totalventa;
                indiceboton[ii, ij] = boton[ii,ij].Name;
            }
            else
            {
                int index = 0;
                bool exist = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {

                    if (listBox1.Items[i].ToString() == "" + bt.Name + " :$" + bt.Tag + "   X" + bt.Text)
                    {
                        exist = true;
                        index = i;
                    }

                }
                if (exist)
                {
                    listBox1.Items.RemoveAt(index);
                    carrito++;
                    bt.Text = carrito.ToString();
                    listBox1.Items.Insert(index, ("" + bt.Name + " :$" + bt.Tag + "   X" + bt.Text));
                    subtotal += Convert.ToInt16(bt.Tag);
                    totalventa = subtotal * (1 + iva);
                    subtotallabel.Text = "Subtotal: $" + subtotal;
                    ventaLabel.Text = "Total: $" + totalventa;
                }
                else
                {
                    carrito++;
                    bt.Text = carrito.ToString();
                    listBox1.Items.Add("" + bt.Name + " :$" + bt.Tag + "   X" + bt.Text);
                    subtotal+= Convert.ToInt16(bt.Tag);
                    totalventa = subtotal * (1 + iva);
                    subtotallabel.Text = "Subtotal: $" + subtotal;
                    ventaLabel.Text = "Total: $" + totalventa;
                    indiceboton[ii, ij] = boton[ii,ij].Name.ToString();
                }
            }
            
            
            
            
        }
        public string permiso = "Admin";

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ivaDS.Iva' table. You can move, or remove it, as needed.
            this.ivaTableAdapter.Fill(this.ivaDS.Iva);
            // TODO: This line of code loads data into the 'utilidadesDS.Utilidades' table. You can move, or remove it, as needed.
            this.utilidadesTableAdapter.Fill(this.utilidadesDS.Utilidades);
            // TODO: This line of code loads data into the 'productoDS.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            // TODO: This line of code loads data into the 'precioDS.Precios' table. You can move, or remove it, as needed.
            this.preciosTableAdapter.Fill(this.precioDS.Precios);
            Ivalabel.Text ="IVA: "+ ivaTableAdapter.Getiva().ToString()+"%" ;
            iva =Convert.ToDecimal( ivaTableAdapter.Getiva()) / 100;
            if (permiso != "Admin")
            {
                button11.Visible = false;
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            Ajusteprecio a = new Ajusteprecio();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
            this.productoTableAdapter.Fill(this.productoDS.Producto);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Dispose();
        }

        private void preciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.precioDS);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string data = listBox1.Items[listBox1.SelectedIndex].ToString();
            string [] word =  data.Split(' ');
            
            bool found = false;
            for (int i = 0; i < indiceboton.GetLength(0) &&found == false; i++)
            {
                for (int j = 0; j < indiceboton.GetLength(1) && found == false; j++)
                {
                    
                    if (indiceboton[i,j] == word[0])
                    {
                        found = true;
                        int cant = Convert.ToInt16(boton[i, j].Text);
                        cant--;
                        if (cant == 0)
                        {
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                            boton[i, j].Text = "0";
                        }
                        else
                        {
                            boton[i, j].Text = cant.ToString();
                            listBox1.Items.Insert(listBox1.SelectedIndex, boton[i, j].Name + " :$" + boton[i,j].Tag + "   X" + boton[i, j].Text);
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                            
                            
                        }
                        subtotal-= Convert.ToInt16(boton[i, j].Tag);
                        totalventa = subtotal * (1 + iva);
                        subtotallabel.Text = "Subtotal: $" + subtotal;
                        ventaLabel.Text = "Total: $" + totalventa;

                    }
                }   
            }
            
        }
        public void clean() 
        {
            listBox1.Items.Clear();
            totalventa = 0;
            subtotal = 0;
            for (int i = 0; i < boton.GetLength(0); i++)
            {
                for (int j = 0; j < boton.GetLength(1); j++)
                {
                    if (boton[i,j] != null)
                    {
                        boton[i, j].Text = "0";      
                    }
                    
                }
            }
            ventaLabel.Text = "Total: $0";
            subtotallabel.Text = "Subtotal: $0";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (listBox1.Items.Count != 0)
            {
                DateTime fec = DateTime.Now;

                if (Convert.ToInt16(utilidadesTableAdapter.Yahizoventa(fec.Year + "-" + fec.Month + "-" + fec.Day, Program.nombredeusuario)) == 1)
                {
                    int cantidad = Convert.ToInt16(utilidadesTableAdapter.GetPollos(Program.nombredeusuario));
                    cantidad = cantidad + Convert.ToInt16(boton[0, 0].Text);
                    utilidadesTableAdapter.UpdateVenta(cantidad, Program.nombredeusuario);
                    MessageBox.Show("Venta registrada con exito");

                }
                else
                {
                    utilidadesTableAdapter.NewVenta(Convert.ToInt16(boton[0, 0].Text), Convert.ToInt16(boton[0, 0].Tag), Program.nombredeusuario);
                    MessageBox.Show("Venta registrada con exito");

                }
                //Creacion DE TICKET
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "PFD Document|*.pdf";
                //saveFileDialog1.Title = "Save an Document File";
                //saveFileDialog1.ShowDialog();
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Rigor\Documents\Visual Studio 2010\Projects\Elpollonsys\Elpollonsys\ticket.pdf", FileMode.Create));
                doc.Open();
                doc.Open();
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Users\Rigor\Documents\Visual Studio 2010\Projects\Elpollonsys\Elpollonsys\Captura.png");
                imagen.Alignment = Element.ALIGN_CENTER;



                Paragraph lista = new Paragraph("\nLista de compra: ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(imagen);
                Paragraph loatiende = new Paragraph("Lo atendio: " + Program.nombredeusuario, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(loatiende);
                Paragraph paragraph = new Paragraph(string.Format("Registro de compra"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 18, iTextSharp.text.Font.BOLD));
                paragraph.Alignment = Element.TITLE;
                doc.Add(paragraph);
                doc.Add(lista);
                Paragraph[] produclist = new Paragraph[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    produclist[i] = new Paragraph("" + listBox1.Items[i].ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 18, iTextSharp.text.Font.BOLD));
                    doc.Add(produclist[i]);
                }
                Paragraph Line = new Paragraph("------------------------------------------------------------", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(Line);
                Paragraph subto = new Paragraph("" + subtotallabel.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(subto);
                Paragraph ivi = new Paragraph("" + Ivalabel.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(ivi);

                Paragraph Totalu = new Paragraph("" + ventaLabel.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14));
                doc.Add(Totalu);

                doc.Close();
                Form2 f = new Form2();
                f.file = @"C:\Users\Rigor\Documents\Visual Studio 2010\Projects\Elpollonsys\Elpollonsys\ticket.pdf";
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                clean();
            }
            else
            {
                MessageBox.Show("Seleccione productos para concluir la venta");
            }


            //Process p = new Process();
            //ProcessStartInfo s = new ProcessStartInfo(saveFileDialog1.FileName);
            //p.StartInfo = s;
            //p.Start();
        }

     
    }
}
