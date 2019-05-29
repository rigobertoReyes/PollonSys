namespace Elpollonsys
{
    partial class formeditarproducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label cantidadEstanteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formeditarproducto));
            this.cantidadEstanteTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productoDS = new Elpollonsys.ProductoDS();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Elpollonsys.ProductoDSTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new Elpollonsys.ProductoDSTableAdapters.TableAdapterManager();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            cantidadEstanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.BackColor = System.Drawing.Color.Transparent;
            nombreProductoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombreProductoLabel.Location = new System.Drawing.Point(38, 31);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(91, 13);
            nombreProductoLabel.TabIndex = 38;
            nombreProductoLabel.Text = "nombre Producto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.Color.Transparent;
            precioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            precioLabel.Location = new System.Drawing.Point(38, 57);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 39;
            precioLabel.Text = "precio:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.BackColor = System.Drawing.Color.Transparent;
            imagenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            imagenLabel.Location = new System.Drawing.Point(38, 83);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(44, 13);
            imagenLabel.TabIndex = 40;
            imagenLabel.Text = "imagen:";
            // 
            // cantidadEstanteLabel
            // 
            cantidadEstanteLabel.AutoSize = true;
            cantidadEstanteLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadEstanteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cantidadEstanteLabel.Location = new System.Drawing.Point(38, 109);
            cantidadEstanteLabel.Name = "cantidadEstanteLabel";
            cantidadEstanteLabel.Size = new System.Drawing.Size(90, 13);
            cantidadEstanteLabel.TabIndex = 41;
            cantidadEstanteLabel.Text = "cantidad Estante:";
            // 
            // cantidadEstanteTextBox
            // 
            this.cantidadEstanteTextBox.Location = new System.Drawing.Point(135, 106);
            this.cantidadEstanteTextBox.Name = "cantidadEstanteTextBox";
            this.cantidadEstanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadEstanteTextBox.TabIndex = 46;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.Location = new System.Drawing.Point(135, 79);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.Size = new System.Drawing.Size(58, 20);
            this.imagenTextBox.TabIndex = 45;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(135, 51);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 44;
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.Location = new System.Drawing.Point(135, 24);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProductoTextBox.TabIndex = 43;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Elpollonsys.Properties.Resources._62319;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(200, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productoDS
            // 
            this.productoDS.DataSetName = "ProductoDS";
            this.productoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.productoDS;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Elpollonsys.ProductoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formeditarproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elpollonsys.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cantidadEstanteTextBox);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(nombreProductoLabel);
            this.Controls.Add(precioLabel);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(cantidadEstanteLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formeditarproducto";
            this.Text = "formeditarproducto";
            this.Load += new System.EventHandler(this.formeditarproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantidadEstanteTextBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ProductoDS productoDS;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ProductoDSTableAdapters.ProductoTableAdapter productoTableAdapter;
        private ProductoDSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}