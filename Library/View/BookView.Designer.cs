namespace Library.View
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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(494, 135);
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
            this.btnSave.Location = new System.Drawing.Point(332, 135);
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
            this.btnBorrow.Location = new System.Drawing.Point(8, 135);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(156, 45);
            this.btnBorrow.TabIndex = 11;
            this.btnBorrow.Text = "Borrow";
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
            this.btnSetAuthor.Location = new System.Drawing.Point(170, 135);
            this.btnSetAuthor.Name = "btnSetAuthor";
            this.btnSetAuthor.Size = new System.Drawing.Size(156, 45);
            this.btnSetAuthor.TabIndex = 14;
            this.btnSetAuthor.Text = "Set Author";
            this.btnSetAuthor.UseVisualStyleBackColor = true;
            this.btnSetAuthor.Click += new System.EventHandler(this.btnSetAuthor_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 192);
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
            this.Text = "Reader";
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
    }
}