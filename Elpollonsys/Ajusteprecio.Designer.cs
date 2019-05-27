namespace Elpollonsys
{
    partial class Ajusteprecio
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
            this.preciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioDS = new Elpollonsys.PrecioDS();
            this.preciosTableAdapter = new Elpollonsys.PrecioDSTableAdapters.PreciosTableAdapter();
            this.tableAdapterManager = new Elpollonsys.PrecioDSTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDS = new Elpollonsys.ProductoDS();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.cantidadEstanteTextBox = new System.Windows.Forms.TextBox();
            this.productoTableAdapter = new Elpollonsys.ProductoDSTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager1 = new Elpollonsys.ProductoDSTableAdapters.TableAdapterManager();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            cantidadEstanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.BackColor = System.Drawing.Color.Transparent;
            nombreProductoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombreProductoLabel.Location = new System.Drawing.Point(33, 41);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(91, 13);
            nombreProductoLabel.TabIndex = 24;
            nombreProductoLabel.Text = "nombre Producto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.Color.Transparent;
            precioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            precioLabel.Location = new System.Drawing.Point(33, 67);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 26;
            precioLabel.Text = "precio:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.BackColor = System.Drawing.Color.Transparent;
            imagenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            imagenLabel.Location = new System.Drawing.Point(33, 93);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(44, 13);
            imagenLabel.TabIndex = 28;
            imagenLabel.Text = "imagen:";
            // 
            // cantidadEstanteLabel
            // 
            cantidadEstanteLabel.AutoSize = true;
            cantidadEstanteLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadEstanteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cantidadEstanteLabel.Location = new System.Drawing.Point(33, 119);
            cantidadEstanteLabel.Name = "cantidadEstanteLabel";
            cantidadEstanteLabel.Size = new System.Drawing.Size(90, 13);
            cantidadEstanteLabel.TabIndex = 30;
            cantidadEstanteLabel.Text = "cantidad Estante:";
            // 
            // preciosBindingSource
            // 
            this.preciosBindingSource.DataMember = "Precios";
            this.preciosBindingSource.DataSource = this.precioDS;
            // 
            // precioDS
            // 
            this.precioDS.DataSetName = "PrecioDS";
            this.precioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preciosTableAdapter
            // 
            this.preciosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PreciosTableAdapter = this.preciosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Elpollonsys.PrecioDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToResizeColumns = false;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(245, 12);
            this.productoDataGridView.MultiSelect = false;
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productoDataGridView.Size = new System.Drawing.Size(342, 220);
            this.productoDataGridView.TabIndex = 31;
            this.productoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellClick);
            
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombreProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "imagen";
            this.dataGridViewTextBoxColumn4.HeaderText = "imagen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidadEstante";
            this.dataGridViewTextBoxColumn5.HeaderText = "cantidadEstante";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.productoDS;
            // 
            // productoDS
            // 
            this.productoDS.DataSetName = "ProductoDS";
            this.productoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Elpollonsys.Properties.Resources._62319;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(195, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.Location = new System.Drawing.Point(130, 34);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProductoTextBox.TabIndex = 34;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(130, 61);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 35;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.Location = new System.Drawing.Point(130, 89);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.Size = new System.Drawing.Size(58, 20);
            this.imagenTextBox.TabIndex = 36;
            // 
            // cantidadEstanteTextBox
            // 
            this.cantidadEstanteTextBox.Location = new System.Drawing.Point(130, 116);
            this.cantidadEstanteTextBox.Name = "cantidadEstanteTextBox";
            this.cantidadEstanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadEstanteTextBox.TabIndex = 37;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Elpollonsys.ProductoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Ajusteprecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elpollonsys.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 260);
            this.Controls.Add(this.cantidadEstanteTextBox);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(nombreProductoLabel);
            this.Controls.Add(precioLabel);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(cantidadEstanteLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Ajusteprecio";
            this.Text = "Ajusteprecio";
            this.Load += new System.EventHandler(this.Ajusteprecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrecioDS precioDS;
        private System.Windows.Forms.BindingSource preciosBindingSource;
        private PrecioDSTableAdapters.PreciosTableAdapter preciosTableAdapter;
        private PrecioDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ProductoDS productoDS;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ProductoDSTableAdapters.ProductoTableAdapter productoTableAdapter;
        private ProductoDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox cantidadEstanteTextBox;
    }
}