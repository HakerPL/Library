namespace Library.View
{
    partial class BorrowBookView
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
            this.lblSelectSearch = new System.Windows.Forms.Label();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearchReader = new System.Windows.Forms.TextBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.cbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectSearch
            // 
            this.lblSelectSearch.AutoSize = true;
            this.lblSelectSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSelectSearch.Name = "lblSelectSearch";
            this.lblSelectSearch.Size = new System.Drawing.Size(65, 13);
            this.lblSelectSearch.TabIndex = 27;
            this.lblSelectSearch.Text = "Search after";
            // 
            // cbSearchOptions
            // 
            this.cbSearchOptions.FormattingEnabled = true;
            this.cbSearchOptions.Items.AddRange(new object[] {
            "Name",
            "Surname"});
            this.cbSearchOptions.Location = new System.Drawing.Point(12, 25);
            this.cbSearchOptions.Name = "cbSearchOptions";
            this.cbSearchOptions.Size = new System.Drawing.Size(135, 21);
            this.cbSearchOptions.TabIndex = 26;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(163, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Search";
            // 
            // tbSearchReader
            // 
            this.tbSearchReader.Location = new System.Drawing.Point(163, 25);
            this.tbSearchReader.Name = "tbSearchReader";
            this.tbSearchReader.Size = new System.Drawing.Size(135, 20);
            this.tbSearchReader.TabIndex = 24;
            this.tbSearchReader.TextChanged += new System.EventHandler(this.tbSearchReader_TextChanged);
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(12, 437);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(135, 23);
            this.btnAddReader.TabIndex = 23;
            this.btnAddReader.Text = "Add New Reader";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(479, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.dgvReaders.Location = new System.Drawing.Point(12, 52);
            this.dgvReaders.MultiSelect = false;
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.ReadOnly = true;
            this.dgvReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReaders.Size = new System.Drawing.Size(602, 379);
            this.dgvReaders.TabIndex = 30;
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
            // BorrowBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 467);
            this.Controls.Add(this.dgvReaders);
            this.Controls.Add(this.lblSelectSearch);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchReader);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.btnCancel);
            this.Name = "BorrowBookView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearchReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbBornDate;
    }
}