﻿namespace Library.View
{
    partial class BookView
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.dtbReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btnSetAuthor = new System.Windows.Forms.Button();
            this.dgvHistoryBook = new System.Windows.Forms.DataGridView();
            this.clReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(494, 505);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(72, 23);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(232, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(72, 59);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(232, 20);
            this.tbIsbn.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(7, 62);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 5;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(329, 26);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(70, 13);
            this.lblReleaseDate.TabIndex = 6;
            this.lblReleaseDate.Text = "Release date";
            // 
            // dtbReleaseDate
            // 
            this.dtbReleaseDate.Location = new System.Drawing.Point(418, 26);
            this.dtbReleaseDate.Name = "dtbReleaseDate";
            this.dtbReleaseDate.Size = new System.Drawing.Size(232, 20);
            this.dtbReleaseDate.TabIndex = 7;
            this.dtbReleaseDate.Value = new System.DateTime(2018, 5, 13, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(332, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbBookType
            // 
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Items.AddRange(new object[] {
            "Name",
            "Surname"});
            this.cbBookType.Location = new System.Drawing.Point(418, 61);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(232, 21);
            this.cbBookType.TabIndex = 9;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(329, 64);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(55, 13);
            this.lblBookType.TabIndex = 10;
            this.lblBookType.Text = "Book type";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrow.Location = new System.Drawing.Point(8, 505);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(156, 45);
            this.btnBorrow.TabIndex = 11;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(7, 101);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Enabled = false;
            this.tbAuthor.Location = new System.Drawing.Point(72, 98);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(578, 20);
            this.tbAuthor.TabIndex = 13;
            // 
            // btnSetAuthor
            // 
            this.btnSetAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetAuthor.Location = new System.Drawing.Point(170, 505);
            this.btnSetAuthor.Name = "btnSetAuthor";
            this.btnSetAuthor.Size = new System.Drawing.Size(156, 45);
            this.btnSetAuthor.TabIndex = 14;
            this.btnSetAuthor.Text = "Set Author";
            this.btnSetAuthor.UseVisualStyleBackColor = true;
            this.btnSetAuthor.Click += new System.EventHandler(this.btnSetAuthor_Click);
            // 
            // dgvHistoryBook
            // 
            this.dgvHistoryBook.AllowUserToAddRows = false;
            this.dgvHistoryBook.AllowUserToDeleteRows = false;
            this.dgvHistoryBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoryBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReaderName,
            this.clReturnDate,
            this.clBorrowDate});
            this.dgvHistoryBook.Location = new System.Drawing.Point(8, 151);
            this.dgvHistoryBook.Name = "dgvHistoryBook";
            this.dgvHistoryBook.ReadOnly = true;
            this.dgvHistoryBook.Size = new System.Drawing.Size(642, 348);
            this.dgvHistoryBook.TabIndex = 15;
            // 
            // clReaderName
            // 
            this.clReaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clReaderName.DataPropertyName = "ReaderName";
            this.clReaderName.HeaderText = "Reader Name";
            this.clReaderName.Name = "clReaderName";
            this.clReaderName.ReadOnly = true;
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
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(7, 135);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(39, 13);
            this.lblHistory.TabIndex = 16;
            this.lblHistory.Text = "History";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnBook.Location = new System.Drawing.Point(8, 505);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(156, 45);
            this.btnReturnBook.TabIndex = 17;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Visible = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 562);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvHistoryBook);
            this.Controls.Add(this.btnSetAuthor);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.cbBookType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtbReleaseDate);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnCancel);
            this.Name = "BookView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.DateTimePicker dtbReleaseDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btnSetAuthor;
        private System.Windows.Forms.DataGridView dgvHistoryBook;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBorrowDate;
        private System.Windows.Forms.Button btnReturnBook;
    }
}