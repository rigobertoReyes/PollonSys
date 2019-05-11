namespace Elpollonsys
{
    partial class UYPerdidas
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
            this.perdidasDS = new Elpollonsys.PerdidasDS();
            this.perdidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perdidasTableAdapter = new Elpollonsys.PerdidasDSTableAdapters.PerdidasTableAdapter();
            this.tableAdapterManager = new Elpollonsys.PerdidasDSTableAdapters.TableAdapterManager();
            this.perdidasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perdidasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perdidasDS
            // 
            this.perdidasDS.DataSetName = "PerdidasDS";
            this.perdidasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perdidasBindingSource
            // 
            this.perdidasBindingSource.DataMember = "Perdidas";
            this.perdidasBindingSource.DataSource = this.perdidasDS;
            // 
            // perdidasTableAdapter
            // 
            this.perdidasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PerdidasTableAdapter = this.perdidasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Elpollonsys.PerdidasDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // perdidasDataGridView
            // 
            this.perdidasDataGridView.AutoGenerateColumns = false;
            this.perdidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perdidasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.perdidasDataGridView.DataSource = this.perdidasBindingSource;
            this.perdidasDataGridView.Location = new System.Drawing.Point(48, 51);
            this.perdidasDataGridView.Name = "perdidasDataGridView";
            this.perdidasDataGridView.Size = new System.Drawing.Size(543, 220);
            this.perdidasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaPerdida";
            this.dataGridViewTextBoxColumn2.HeaderText = "fechaPerdida";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idLote";
            this.dataGridViewTextBoxColumn5.HeaderText = "idLote";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Utilidades y Perdidas";
            // 
            // UYPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elpollonsys.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perdidasDataGridView);
            this.Name = "UYPerdidas";
            this.Text = "UYPerdidas";
            this.Load += new System.EventHandler(this.UYPerdidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perdidasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdidasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PerdidasDS perdidasDS;
        private System.Windows.Forms.BindingSource perdidasBindingSource;
        private PerdidasDSTableAdapters.PerdidasTableAdapter perdidasTableAdapter;
        private PerdidasDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView perdidasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}