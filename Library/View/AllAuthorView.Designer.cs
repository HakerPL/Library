namespace Library.View
{
    partial class AllAuthorView
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
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnRemoveAuthor = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.tbSearchAuthor = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblSelectSearch = new System.Windows.Forms.Label();
            this.btnShowAllAuthors = new System.Windows.Forms.Button();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.cbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(3, 308);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(135, 23);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Location = new System.Drawing.Point(3, 337);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(135, 23);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.Text = "Edit";
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.Location = new System.Drawing.Point(3, 366);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveAuthor.TabIndex = 3;
            this.btnRemoveAuthor.Text = "Remove";
            this.btnRemoveAuthor.UseVisualStyleBackColor = true;
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(3, 112);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(135, 23);
            this.btnSearchAuthor.TabIndex = 4;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // tbSearchAuthor
            // 
            this.tbSearchAuthor.Location = new System.Drawing.Point(3, 86);
            this.tbSearchAuthor.Name = "tbSearchAuthor";
            this.tbSearchAuthor.Size = new System.Drawing.Size(135, 20);
            this.tbSearchAuthor.TabIndex = 5;
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
            // btnShowAllAuthors
            // 
            this.btnShowAllAuthors.Location = new System.Drawing.Point(3, 141);
            this.btnShowAllAuthors.Name = "btnShowAllAuthors";
            this.btnShowAllAuthors.Size = new System.Drawing.Size(135, 23);
            this.btnShowAllAuthors.TabIndex = 9;
            this.btnShowAllAuthors.Text = "Show all Authors";
            this.btnShowAllAuthors.UseVisualStyleBackColor = true;
            this.btnShowAllAuthors.Click += new System.EventHandler(this.btnShowAllAuthors_Click);
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbName,
            this.cbSurname,
            this.cbBornDate});
            this.dgvAuthors.Location = new System.Drawing.Point(147, 3);
            this.dgvAuthors.MultiSelect = false;
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new System.Drawing.Size(573, 388);
            this.dgvAuthors.TabIndex = 10;
            this.dgvAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellDoubleClick);
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
            // AllAuthorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.btnShowAllAuthors);
            this.Controls.Add(this.lblSelectSearch);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchAuthor);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.btnRemoveAuthor);
            this.Controls.Add(this.btnEditAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Name = "AllAuthorView";
            this.Size = new System.Drawing.Size(720, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.Button btnRemoveAuthor;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox tbSearchAuthor;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
        private System.Windows.Forms.Label lblSelectSearch;
        private System.Windows.Forms.Button btnShowAllAuthors;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbBornDate;
    }
}
