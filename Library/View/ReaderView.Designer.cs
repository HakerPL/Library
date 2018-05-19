namespace Library.View
{
    partial class ReaderView
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.dtbBornDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvHistoryReader = new System.Windows.Forms.DataGridView();
            this.clBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryReader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(511, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(435, 23);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(232, 20);
            this.tbSurname.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(346, 26);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(7, 62);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(53, 13);
            this.lblBornDate.TabIndex = 6;
            this.lblBornDate.Text = "Born date";
            // 
            // dtbBornDate
            // 
            this.dtbBornDate.Location = new System.Drawing.Point(96, 62);
            this.dtbBornDate.Name = "dtbBornDate";
            this.dtbBornDate.Size = new System.Drawing.Size(232, 20);
            this.dtbBornDate.TabIndex = 7;
            this.dtbBornDate.Value = new System.DateTime(2018, 5, 13, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(349, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvHistoryReader
            // 
            this.dgvHistoryReader.AllowUserToAddRows = false;
            this.dgvHistoryReader.AllowUserToDeleteRows = false;
            this.dgvHistoryReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoryReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBookTitle,
            this.clReturnDate,
            this.clBorrowDate});
            this.dgvHistoryReader.Location = new System.Drawing.Point(12, 88);
            this.dgvHistoryReader.Name = "dgvHistoryReader";
            this.dgvHistoryReader.ReadOnly = true;
            this.dgvHistoryReader.Size = new System.Drawing.Size(655, 347);
            this.dgvHistoryReader.TabIndex = 16;
            // 
            // clBookTitle
            // 
            this.clBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clBookTitle.DataPropertyName = "BookTitle";
            this.clBookTitle.HeaderText = "Book Title";
            this.clBookTitle.Name = "clBookTitle";
            this.clBookTitle.ReadOnly = true;
            // 
            // clReturnDate
            // 
            this.clReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clReturnDate.DataPropertyName = "ReturnDate";
            this.clReturnDate.HeaderText = "Return Date";
            this.clReturnDate.Name = "clReturnDate";
            this.clReturnDate.ReadOnly = true;
            // 
            // clBorrowDate
            // 
            this.clBorrowDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clBorrowDate.DataPropertyName = "BorrowedDate";
            this.clBorrowDate.HeaderText = "Borrow Date";
            this.clBorrowDate.Name = "clBorrowDate";
            this.clBorrowDate.ReadOnly = true;
            // 
            // ReaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 499);
            this.Controls.Add(this.dgvHistoryReader);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtbBornDate);
            this.Controls.Add(this.lblBornDate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancel);
            this.Name = "ReaderView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.DateTimePicker dtbBornDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvHistoryReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBorrowDate;
    }
}