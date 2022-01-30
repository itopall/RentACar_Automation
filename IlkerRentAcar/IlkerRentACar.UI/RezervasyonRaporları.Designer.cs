namespace IlkerRentACar.UI
{
    partial class RezervasyonRaporları
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
            this.grdRezRapor = new System.Windows.Forms.DataGridView();
            this.satisDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRezRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRezRapor
            // 
            this.grdRezRapor.AllowUserToAddRows = false;
            this.grdRezRapor.AutoGenerateColumns = false;
            this.grdRezRapor.BackgroundColor = System.Drawing.Color.White;
            this.grdRezRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRezRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.musteriIdDataGridViewTextBoxColumn,
            this.aracIdDataGridViewTextBoxColumn,
            this.rezervasyonIdDataGridViewTextBoxColumn,
            this.kiraIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.updateByDataGridViewTextBoxColumn,
            this.ısActiveDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn});
            this.grdRezRapor.DataSource = this.satisDtoBindingSource;
            this.grdRezRapor.GridColor = System.Drawing.Color.White;
            this.grdRezRapor.Location = new System.Drawing.Point(29, 136);
            this.grdRezRapor.Name = "grdRezRapor";
            this.grdRezRapor.RowHeadersWidth = 51;
            this.grdRezRapor.RowTemplate.Height = 24;
            this.grdRezRapor.Size = new System.Drawing.Size(1024, 434);
            this.grdRezRapor.TabIndex = 2;
            this.grdRezRapor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRezRapor_CellClick);
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
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // aracIdDataGridViewTextBoxColumn
            // 
            this.aracIdDataGridViewTextBoxColumn.DataPropertyName = "AracId";
            this.aracIdDataGridViewTextBoxColumn.HeaderText = "AracId";
            this.aracIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracIdDataGridViewTextBoxColumn.Name = "aracIdDataGridViewTextBoxColumn";
            this.aracIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // rezervasyonIdDataGridViewTextBoxColumn
            // 
            this.rezervasyonIdDataGridViewTextBoxColumn.DataPropertyName = "RezervasyonId";
            this.rezervasyonIdDataGridViewTextBoxColumn.HeaderText = "RezervasyonId";
            this.rezervasyonIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezervasyonIdDataGridViewTextBoxColumn.Name = "rezervasyonIdDataGridViewTextBoxColumn";
            this.rezervasyonIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiraIdDataGridViewTextBoxColumn
            // 
            this.kiraIdDataGridViewTextBoxColumn.DataPropertyName = "KiraId";
            this.kiraIdDataGridViewTextBoxColumn.HeaderText = "KiraId";
            this.kiraIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiraIdDataGridViewTextBoxColumn.Name = "kiraIdDataGridViewTextBoxColumn";
            this.kiraIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateByDataGridViewTextBoxColumn
            // 
            this.updateByDataGridViewTextBoxColumn.DataPropertyName = "UpdateBy";
            this.updateByDataGridViewTextBoxColumn.HeaderText = "UpdateBy";
            this.updateByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateByDataGridViewTextBoxColumn.Name = "updateByDataGridViewTextBoxColumn";
            this.updateByDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısActiveDataGridViewTextBoxColumn
            // 
            this.ısActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.ısActiveDataGridViewTextBoxColumn.HeaderText = "IsActive";
            this.ısActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ısActiveDataGridViewTextBoxColumn.Name = "ısActiveDataGridViewTextBoxColumn";
            this.ısActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // RezervasyonRaporları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 662);
            this.Controls.Add(this.grdRezRapor);
            this.Name = "RezervasyonRaporları";
            this.Text = "RezervasyonRaporları";
            this.Load += new System.EventHandler(this.RezervasyonRaporları_Load);
            this.Controls.SetChildIndex(this.btnGuncelle, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.grdRezRapor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdRezRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRezRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource satisDtoBindingSource;
    }
}