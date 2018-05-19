﻿namespace Library.View
{
    partial class AllReadersViews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.cbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnEditReader = new System.Windows.Forms.Button();
            this.btnRemoveReader = new System.Windows.Forms.Button();
            this.tbSearchReader = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblSelectSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReaders
            // 
            this.dgvReaders.AllowUserToAddRows = false;
            this.dgvReaders.AllowUserToDeleteRows = false;
            this.dgvReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbName,
            this.cbSurname,
            this.cbBornDate});
            this.dgvReaders.Location = new System.Drawing.Point(147, 3);
            this.dgvReaders.MultiSelect = false;
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.ReadOnly = true;
            this.dgvReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReaders.Size = new System.Drawing.Size(573, 388);
            this.dgvReaders.TabIndex = 0;
            this.dgvReaders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReaders_CellDoubleClick);
            // 
            // cbName
            // 
            this.cbName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbName.DataPropertyName = "Name";
            this.cbName.HeaderText = "Name";
            this.cbName.Name = "cbName";
            this.cbName.ReadOnly = true;
            // 
            // cbSurname
            // 
            this.cbSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbSurname.DataPropertyName = "Surname";
            this.cbSurname.HeaderText = "Surname";
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.ReadOnly = true;
            // 
            // cbBornDate
            // 
            this.cbBornDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbBornDate.DataPropertyName = "BornDate";
            this.cbBornDate.HeaderText = "Born date";
            this.cbBornDate.Name = "cbBornDate";
            this.cbBornDate.ReadOnly = true;
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(3, 308);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(135, 23);
            this.btnAddReader.TabIndex = 1;
            this.btnAddReader.Text = "Add";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnEditReader
            // 
            this.btnEditReader.Location = new System.Drawing.Point(3, 337);
            this.btnEditReader.Name = "btnEditReader";
            this.btnEditReader.Size = new System.Drawing.Size(135, 23);
            this.btnEditReader.TabIndex = 2;
            this.btnEditReader.Text = "Edit";
            this.btnEditReader.UseVisualStyleBackColor = true;
            this.btnEditReader.Click += new System.EventHandler(this.btnEditReader_Click);
            // 
            // btnRemoveReader
            // 
            this.btnRemoveReader.Location = new System.Drawing.Point(3, 366);
            this.btnRemoveReader.Name = "btnRemoveReader";
            this.btnRemoveReader.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveReader.TabIndex = 3;
            this.btnRemoveReader.Text = "Remove";
            this.btnRemoveReader.UseVisualStyleBackColor = true;
            this.btnRemoveReader.Click += new System.EventHandler(this.btnRemoveReader_Click);
            // 
            // tbSearchReader
            // 
            this.tbSearchReader.Location = new System.Drawing.Point(3, 86);
            this.tbSearchReader.Name = "tbSearchReader";
            this.tbSearchReader.Size = new System.Drawing.Size(135, 20);
            this.tbSearchReader.TabIndex = 5;
            this.tbSearchReader.TextChanged += new System.EventHandler(this.tbSearchReader_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 70);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            // 
            // cbSearchOptions
            // 
            this.cbSearchOptions.FormattingEnabled = true;
            this.cbSearchOptions.Items.AddRange(new object[] {
            "Name",
            "Surname"});
            this.cbSearchOptions.Location = new System.Drawing.Point(3, 46);
            this.cbSearchOptions.Name = "cbSearchOptions";
            this.cbSearchOptions.Size = new System.Drawing.Size(135, 21);
            this.cbSearchOptions.TabIndex = 7;
            // 
            // lblSelectSearch
            // 
            this.lblSelectSearch.AutoSize = true;
            this.lblSelectSearch.Location = new System.Drawing.Point(3, 30);
            this.lblSelectSearch.Name = "lblSelectSearch";
            this.lblSelectSearch.Size = new System.Drawing.Size(65, 13);
            this.lblSelectSearch.TabIndex = 8;
            this.lblSelectSearch.Text = "Search after";
            // 
            // AllReadersViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectSearch);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchReader);
            this.Controls.Add(this.btnRemoveReader);
            this.Controls.Add(this.btnEditReader);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.dgvReaders);
            this.Name = "AllReadersViews";
            this.Size = new System.Drawing.Size(720, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnEditReader;
        private System.Windows.Forms.Button btnRemoveReader;
        private System.Windows.Forms.TextBox tbSearchReader;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
        private System.Windows.Forms.Label lblSelectSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbBornDate;
        private System.Windows.Forms.DataGridView dgvReaders;
    }
}
