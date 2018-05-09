namespace Library.View
{
    partial class MainView
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
            this.pView = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnHistoryBooks = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pView
            // 
            this.pView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pView.BackColor = System.Drawing.Color.White;
            this.pView.Location = new System.Drawing.Point(12, 60);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(1048, 436);
            this.pView.TabIndex = 0;
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(12, 12);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(258, 42);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnHistoryBooks
            // 
            this.btnHistoryBooks.Location = new System.Drawing.Point(276, 12);
            this.btnHistoryBooks.Name = "btnHistoryBooks";
            this.btnHistoryBooks.Size = new System.Drawing.Size(258, 42);
            this.btnHistoryBooks.TabIndex = 2;
            this.btnHistoryBooks.Text = "History Book";
            this.btnHistoryBooks.UseVisualStyleBackColor = true;
            this.btnHistoryBooks.Click += new System.EventHandler(this.btnHistoryBooks_Click);
            // 
            // btnReaders
            // 
            this.btnReaders.Location = new System.Drawing.Point(540, 12);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Size = new System.Drawing.Size(258, 42);
            this.btnReaders.TabIndex = 3;
            this.btnReaders.Text = "Readers";
            this.btnReaders.UseVisualStyleBackColor = true;
            this.btnReaders.Click += new System.EventHandler(this.btnReaders_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(804, 12);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(258, 42);
            this.btnAuthors.TabIndex = 4;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 508);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnReaders);
            this.Controls.Add(this.btnHistoryBooks);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.pView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainView";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnHistoryBooks;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnAuthors;
    }
}

