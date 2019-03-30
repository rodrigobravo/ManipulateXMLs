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
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.pnlDateSel = new System.Windows.Forms.Panel();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.lblDateFinal = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.lstFolders = new System.Windows.Forms.ListView();
            this.pnlResult.SuspendLayout();
            this.pnlDateSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(24, 43);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(228, 48);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar Pasta";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblSelectedFolder);
            this.pnlResult.Controls.Add(this.txtTotalCount);
            this.pnlResult.Controls.Add(this.lblTotalCount);
            this.pnlResult.Location = new System.Drawing.Point(282, 43);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(443, 186);
            this.pnlResult.TabIndex = 2;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(85, 55);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCount.TabIndex = 1;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(3, 55);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(76, 13);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "Total de XMLs";
            // 
            // pnlDateSel
            // 
            this.pnlDateSel.Controls.Add(this.btnDateFilter);
            this.pnlDateSel.Controls.Add(this.lblDateFinal);
            this.pnlDateSel.Controls.Add(this.lblDateStart);
            this.pnlDateSel.Controls.Add(this.dtEnd);
            this.pnlDateSel.Controls.Add(this.dtStart);
            this.pnlDateSel.Location = new System.Drawing.Point(24, 97);
            this.pnlDateSel.Name = "pnlDateSel";
            this.pnlDateSel.Size = new System.Drawing.Size(228, 216);
            this.pnlDateSel.TabIndex = 8;
            this.pnlDateSel.Visible = false;
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(85, 100);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(97, 46);
            this.btnDateFilter.TabIndex = 12;
            this.btnDateFilter.Text = "Filtrar Datas";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click_1);
            // 
            // lblDateFinal
            // 
            this.lblDateFinal.AutoSize = true;
            this.lblDateFinal.Location = new System.Drawing.Point(19, 83);
            this.lblDateFinal.Name = "lblDateFinal";
            this.lblDateFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDateFinal.TabIndex = 11;
            this.lblDateFinal.Text = "Data Final";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(19, 50);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(60, 13);
            this.lblDateStart.TabIndex = 10;
            this.lblDateStart.Text = "Data Inicial";
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "DD-MM-YY";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(85, 74);
            this.dtEnd.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(97, 20);
            this.dtEnd.TabIndex = 9;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MM-yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(85, 41);
            this.dtStart.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(97, 20);
            this.dtStart.TabIndex = 8;
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFolder.Location = new System.Drawing.Point(3, 9);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(285, 25);
            this.lblSelectedFolder.TabIndex = 2;
            this.lblSelectedFolder.Text = "Nenhuma pasta selecionada";
            this.lblSelectedFolder.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.Location = new System.Drawing.Point(282, 235);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(443, 77);
            this.lstFolders.TabIndex = 9;
            this.lstFolders.UseCompatibleStateImageBehavior = false;
            this.lstFolders.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.pnlDateSel);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlDateSel.ResumeLayout(false);
            this.pnlDateSel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtTotalCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlDateSel;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.Label lblDateFinal;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.ListView lstFolders;
    }
}

