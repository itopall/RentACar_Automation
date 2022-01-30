namespace IlkerRentACar.UI
{
    partial class KiraRaporlari
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
            this.grdKiralananAraclar = new System.Windows.Forms.DataGridView();
            this.satisDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AracPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdKiralananAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // grdKiralananAraclar
            // 
            this.grdKiralananAraclar.AllowUserToAddRows = false;
            this.grdKiralananAraclar.AllowUserToDeleteRows = false;
            this.grdKiralananAraclar.AutoGenerateColumns = false;
            this.grdKiralananAraclar.BackgroundColor = System.Drawing.Color.White;
            this.grdKiralananAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKiralananAraclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MusteriAdi,
            this.AracPlaka,
            this.UserName,
            this.createdDateDataGridViewTextBoxColumn});
            this.grdKiralananAraclar.DataSource = this.satisDtoBindingSource;
            this.grdKiralananAraclar.GridColor = System.Drawing.Color.White;
            this.grdKiralananAraclar.Location = new System.Drawing.Point(12, 106);
            this.grdKiralananAraclar.Name = "grdKiralananAraclar";
            this.grdKiralananAraclar.RowHeadersWidth = 55;
            this.grdKiralananAraclar.RowTemplate.Height = 25;
            this.grdKiralananAraclar.Size = new System.Drawing.Size(848, 455);
            this.grdKiralananAraclar.TabIndex = 6;
            this.grdKiralananAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKiralananAraclar_CellClick);
            // 
            // satisDtoBindingSource
            // 
            this.satisDtoBindingSource.DataSource = typeof(RentACar.Dto.Dto.SatisDto);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // MusteriAdi
            // 
            this.MusteriAdi.DataPropertyName = "MusteriAdi";
            this.MusteriAdi.HeaderText = "Müşteri Adı";
            this.MusteriAdi.MinimumWidth = 6;
            this.MusteriAdi.Name = "MusteriAdi";
            this.MusteriAdi.Width = 125;
            // 
            // AracPlaka
            // 
            this.AracPlaka.DataPropertyName = "AracPlaka";
            this.AracPlaka.HeaderText = "Araç Plaka";
            this.AracPlaka.MinimumWidth = 6;
            this.AracPlaka.Name = "AracPlaka";
            this.AracPlaka.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "userName";
            this.UserName.HeaderText = "Satış Yapan";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "Kira tarihi";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // KiraRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 731);
            this.Controls.Add(this.grdKiralananAraclar);
            this.Name = "KiraRaporlari";
            this.Text = "KiraRaporlari";
            this.Load += new System.EventHandler(this.KiraRaporlari_Load);
            this.Controls.SetChildIndex(this.btnGuncelle, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.grdKiralananAraclar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdKiralananAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView grdKiralananAraclar;
        private System.Windows.Forms.BindingSource satisDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AracPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}