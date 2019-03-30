namespace ManipulateXMLs
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateFinal = new System.Windows.Forms.Label();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.Location = new System.Drawing.Point(12, 21);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(498, 186);
            this.lstFolders.TabIndex = 0;
            this.lstFolders.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(159, 228);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(152, 64);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar Pasta";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.txtTotalCount);
            this.pnlResult.Controls.Add(this.lblTotalCount);
            this.pnlResult.Location = new System.Drawing.Point(543, 21);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(200, 186);
            this.pnlResult.TabIndex = 2;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(85, 20);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCount.TabIndex = 1;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(3, 20);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(76, 13);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "Total de XMLs";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "DD-MM-YY";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(646, 213);
            this.dtStart.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(97, 20);
            this.dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "DD-MM-YY";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(646, 246);
            this.dtEnd.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(97, 20);
            this.dtEnd.TabIndex = 4;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(580, 219);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(60, 13);
            this.lblDateStart.TabIndex = 5;
            this.lblDateStart.Text = "Data Inicial";
            // 
            // lblDateFinal
            // 
            this.lblDateFinal.AutoSize = true;
            this.lblDateFinal.Location = new System.Drawing.Point(580, 252);
            this.lblDateFinal.Name = "lblDateFinal";
            this.lblDateFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDateFinal.TabIndex = 6;
            this.lblDateFinal.Text = "Data Final";
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(646, 272);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(97, 46);
            this.btnDateFilter.TabIndex = 7;
            this.btnDateFilter.Text = "Filtrar Datas";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDateFilter);
            this.Controls.Add(this.lblDateFinal);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtTotalCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateFinal;
        private System.Windows.Forms.Button btnDateFilter;
    }
}

