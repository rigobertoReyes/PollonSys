namespace Elpollonsys
{
    partial class NuevoLote
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
            System.Windows.Forms.Label idLoteLabel;
            System.Windows.Forms.Label cantidadLoteLabel;
            System.Windows.Forms.Label precioLoteLabel;
            System.Windows.Forms.Label fechaLlegadaLabel;
            System.Windows.Forms.Label fechaAceptableLabel;
            System.Windows.Forms.Label fechaCaducidadLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label estadoLoteLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loteDS = new Elpollonsys.LoteDS();
            this.loteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loteTableAdapter = new Elpollonsys.LoteDSTableAdapters.LoteTableAdapter();
            this.tableAdapterManager = new Elpollonsys.LoteDSTableAdapters.TableAdapterManager();
            this.cantidadLoteTextBox = new System.Windows.Forms.TextBox();
            this.precioLoteTextBox = new System.Windows.Forms.TextBox();
            this.fechaLlegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaAceptableDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCaducidadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            idLoteLabel = new System.Windows.Forms.Label();
            cantidadLoteLabel = new System.Windows.Forms.Label();
            precioLoteLabel = new System.Windows.Forms.Label();
            fechaLlegadaLabel = new System.Windows.Forms.Label();
            fechaAceptableLabel = new System.Windows.Forms.Label();
            fechaCaducidadLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            estadoLoteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loteDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLoteLabel
            // 
            idLoteLabel.AutoSize = true;
            idLoteLabel.Location = new System.Drawing.Point(6, 25);
            idLoteLabel.Name = "idLoteLabel";
            idLoteLabel.Size = new System.Drawing.Size(42, 13);
            idLoteLabel.TabIndex = 3;
            idLoteLabel.Text = "id Lote:";
            // 
            // cantidadLoteLabel
            // 
            cantidadLoteLabel.AutoSize = true;
            cantidadLoteLabel.Location = new System.Drawing.Point(6, 51);
            cantidadLoteLabel.Name = "cantidadLoteLabel";
            cantidadLoteLabel.Size = new System.Drawing.Size(75, 13);
            cantidadLoteLabel.TabIndex = 5;
            cantidadLoteLabel.Text = "cantidad Lote:";
            // 
            // precioLoteLabel
            // 
            precioLoteLabel.AutoSize = true;
            precioLoteLabel.Location = new System.Drawing.Point(6, 77);
            precioLoteLabel.Name = "precioLoteLabel";
            precioLoteLabel.Size = new System.Drawing.Size(63, 13);
            precioLoteLabel.TabIndex = 7;
            precioLoteLabel.Text = "precio Lote:";
            // 
            // fechaLlegadaLabel
            // 
            fechaLlegadaLabel.AutoSize = true;
            fechaLlegadaLabel.Location = new System.Drawing.Point(6, 19);
            fechaLlegadaLabel.Name = "fechaLlegadaLabel";
            fechaLlegadaLabel.Size = new System.Drawing.Size(78, 13);
            fechaLlegadaLabel.TabIndex = 9;
            fechaLlegadaLabel.Text = "fecha Llegada:";
            // 
            // fechaAceptableLabel
            // 
            fechaAceptableLabel.AutoSize = true;
            fechaAceptableLabel.Location = new System.Drawing.Point(6, 45);
            fechaAceptableLabel.Name = "fechaAceptableLabel";
            fechaAceptableLabel.Size = new System.Drawing.Size(88, 13);
            fechaAceptableLabel.TabIndex = 11;
            fechaAceptableLabel.Text = "fecha Aceptable:";
            // 
            // fechaCaducidadLabel
            // 
            fechaCaducidadLabel.AutoSize = true;
            fechaCaducidadLabel.Location = new System.Drawing.Point(6, 71);
            fechaCaducidadLabel.Name = "fechaCaducidadLabel";
            fechaCaducidadLabel.Size = new System.Drawing.Size(91, 13);
            fechaCaducidadLabel.TabIndex = 13;
            fechaCaducidadLabel.Text = "fecha Caducidad:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(6, 25);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 15;
            stockLabel.Text = "stock:";
            // 
            // estadoLoteLabel
            // 
            estadoLoteLabel.AutoSize = true;
            estadoLoteLabel.Location = new System.Drawing.Point(6, 52);
            estadoLoteLabel.Name = "estadoLoteLabel";
            estadoLoteLabel.Size = new System.Drawing.Size(66, 13);
            estadoLoteLabel.TabIndex = 19;
            estadoLoteLabel.Text = "estado Lote:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(257, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 13);
            label1.TabIndex = 15;
            label1.Text = "Dias Aceptables";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 13);
            label2.TabIndex = 16;
            label2.Text = "Dias Caducidad";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(419, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loteDS
            // 
            this.loteDS.DataSetName = "LoteDS";
            this.loteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loteBindingSource
            // 
            this.loteBindingSource.DataMember = "Lote";
            this.loteBindingSource.DataSource = this.loteDS;
            // 
            // loteTableAdapter
            // 
            this.loteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoteTableAdapter = this.loteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Elpollonsys.LoteDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cantidadLoteTextBox
            // 
            this.cantidadLoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteBindingSource, "cantidadLote", true));
            this.cantidadLoteTextBox.Enabled = false;
            this.cantidadLoteTextBox.Location = new System.Drawing.Point(103, 48);
            this.cantidadLoteTextBox.Name = "cantidadLoteTextBox";
            this.cantidadLoteTextBox.Size = new System.Drawing.Size(60, 20);
            this.cantidadLoteTextBox.TabIndex = 6;
            // 
            // precioLoteTextBox
            // 
            this.precioLoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteBindingSource, "precioLote", true));
            this.precioLoteTextBox.Location = new System.Drawing.Point(103, 74);
            this.precioLoteTextBox.Name = "precioLoteTextBox";
            this.precioLoteTextBox.Size = new System.Drawing.Size(60, 20);
            this.precioLoteTextBox.TabIndex = 8;
            // 
            // fechaLlegadaDateTimePicker
            // 
            this.fechaLlegadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loteBindingSource, "fechaLlegada", true));
            this.fechaLlegadaDateTimePicker.Location = new System.Drawing.Point(103, 15);
            this.fechaLlegadaDateTimePicker.Name = "fechaLlegadaDateTimePicker";
            this.fechaLlegadaDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.fechaLlegadaDateTimePicker.TabIndex = 10;
            // 
            // fechaAceptableDateTimePicker
            // 
            this.fechaAceptableDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loteBindingSource, "fechaAceptable", true));
            this.fechaAceptableDateTimePicker.Enabled = false;
            this.fechaAceptableDateTimePicker.Location = new System.Drawing.Point(103, 41);
            this.fechaAceptableDateTimePicker.Name = "fechaAceptableDateTimePicker";
            this.fechaAceptableDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.fechaAceptableDateTimePicker.TabIndex = 12;
            // 
            // fechaCaducidadDateTimePicker
            // 
            this.fechaCaducidadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loteBindingSource, "fechaCaducidad", true));
            this.fechaCaducidadDateTimePicker.Enabled = false;
            this.fechaCaducidadDateTimePicker.Location = new System.Drawing.Point(103, 67);
            this.fechaCaducidadDateTimePicker.Name = "fechaCaducidadDateTimePicker";
            this.fechaCaducidadDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.fechaCaducidadDateTimePicker.TabIndex = 14;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(103, 22);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(60, 20);
            this.stockTextBox.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(idLoteLabel);
            this.groupBox1.Controls.Add(this.precioLoteTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(precioLoteLabel);
            this.groupBox1.Controls.Add(this.cantidadLoteTextBox);
            this.groupBox1.Controls.Add(cantidadLoteLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(33, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del lote";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(stockLabel);
            this.groupBox2.Controls.Add(estadoLoteLabel);
            this.groupBox2.Controls.Add(this.stockTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(242, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 95);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del lote";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(fechaAceptableLabel);
            this.groupBox3.Controls.Add(this.fechaCaducidadDateTimePicker);
            this.groupBox3.Controls.Add(fechaCaducidadLabel);
            this.groupBox3.Controls.Add(fechaLlegadaLabel);
            this.groupBox3.Controls.Add(this.fechaAceptableDateTimePicker);
            this.groupBox3.Controls.Add(this.fechaLlegadaDateTimePicker);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(33, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Establecer fechas";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(340, 68);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(340, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(412, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(412, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.comboBox2.Location = new System.Drawing.Point(103, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // NuevoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elpollonsys.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NuevoLote";
            this.Text = "NuevoLote";
            this.Load += new System.EventHandler(this.NuevoLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loteDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LoteDS loteDS;
        private System.Windows.Forms.BindingSource loteBindingSource;
        private LoteDSTableAdapters.LoteTableAdapter loteTableAdapter;
        private LoteDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cantidadLoteTextBox;
        private System.Windows.Forms.TextBox precioLoteTextBox;
        private System.Windows.Forms.DateTimePicker fechaLlegadaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaAceptableDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaCaducidadDateTimePicker;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}