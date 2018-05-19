namespace Library.View
{
    partial class AllBooksViews
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cbTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBorrowed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.tbSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblSelectSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbTitle,
            this.cbIsbn,
            this.cbBookType,
            this.cbReleaseDate,
            this.cbBorrowed});
            this.dgvBooks.Location = new System.Drawing.Point(144, 3);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(573, 388);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            // 
            // cbTitle
            // 
            this.cbTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbTitle.DataPropertyName = "Title";
            this.cbTitle.HeaderText = "Title";
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.ReadOnly = true;
            // 
            // cbIsbn
            // 
            this.cbIsbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbIsbn.DataPropertyName = "Isbn";
            this.cbIsbn.HeaderText = "ISBN";
            this.cbIsbn.Name = "cbIsbn";
            this.cbIsbn.ReadOnly = true;
            // 
            // cbBookType
            // 
            this.cbBookType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbBookType.DataPropertyName = "BookType";
            this.cbBookType.HeaderText = "Book type";
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.ReadOnly = true;
            // 
            // cbReleaseDate
            // 
            this.cbReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbReleaseDate.DataPropertyName = "ReleaseDate";
            this.cbReleaseDate.HeaderText = "Release date";
            this.cbReleaseDate.Name = "cbReleaseDate";
            this.cbReleaseDate.ReadOnly = true;
            // 
            // cbBorrowed
            // 
            this.cbBorrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbBorrowed.DataPropertyName = "Borrowed";
            this.cbBorrowed.HeaderText = "Borrowed";
            this.cbBorrowed.Name = "cbBorrowed";
            this.cbBorrowed.ReadOnly = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(3, 308);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(135, 23);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(3, 337);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(135, 23);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(3, 366);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveBook.TabIndex = 3;
            this.btnRemoveBook.Text = "Remove";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // tbSearchBook
            // 
            this.tbSearchBook.Location = new System.Drawing.Point(3, 86);
            this.tbSearchBook.Name = "tbSearchBook";
            this.tbSearchBook.Size = new System.Drawing.Size(135, 20);
            this.tbSearchBook.TabIndex = 5;
            this.tbSearchBook.TextChanged += new System.EventHandler(this.tbSearchBook_TextChanged);
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
            "Title",
            "ISBN"});
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
            // AllBooksViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectSearch);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBooks);
            this.Name = "AllBooksViews";
            this.Size = new System.Drawing.Size(720, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.TextBox tbSearchBook;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
        private System.Windows.Forms.Label lblSelectSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbBookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbReleaseDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbBorrowed;
    }
}
