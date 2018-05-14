namespace Library.View
{
    partial class HistoryBookViews
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
            this.dgvHistoryBook = new System.Windows.Forms.DataGridView();
            this.btnSearchHistoryBook = new System.Windows.Forms.Button();
            this.tbSearchHistoryIsbn = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoryBook
            // 
            this.dgvHistoryBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoryBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryBook.Location = new System.Drawing.Point(3, 58);
            this.dgvHistoryBook.Name = "dgvHistoryBook";
            this.dgvHistoryBook.Size = new System.Drawing.Size(714, 333);
            this.dgvHistoryBook.TabIndex = 0;
            // 
            // btnSearchHistoryBook
            // 
            this.btnSearchHistoryBook.Location = new System.Drawing.Point(184, 17);
            this.btnSearchHistoryBook.Name = "btnSearchHistoryBook";
            this.btnSearchHistoryBook.Size = new System.Drawing.Size(135, 23);
            this.btnSearchHistoryBook.TabIndex = 4;
            this.btnSearchHistoryBook.Text = "Search";
            this.btnSearchHistoryBook.UseVisualStyleBackColor = true;
            // 
            // tbSearchHistoryIsbn
            // 
            this.tbSearchHistoryIsbn.Location = new System.Drawing.Point(3, 19);
            this.tbSearchHistoryIsbn.Name = "tbSearchHistoryIsbn";
            this.tbSearchHistoryIsbn.Size = new System.Drawing.Size(158, 20);
            this.tbSearchHistoryIsbn.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search by ISBN";
            // 
            // HistoryBooksViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchHistoryIsbn);
            this.Controls.Add(this.btnSearchHistoryBook);
            this.Controls.Add(this.dgvHistoryBook);
            this.Name = "HistoryBooksViews";
            this.Size = new System.Drawing.Size(720, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoryBook;
        private System.Windows.Forms.Button btnSearchHistoryBook;
        private System.Windows.Forms.TextBox tbSearchHistoryIsbn;
        private System.Windows.Forms.Label lblSearch;
    }
}
