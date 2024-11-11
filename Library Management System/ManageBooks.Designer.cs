namespace Library_Management_System
{
	partial class ManageBooks
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
			this.gvBooksData = new System.Windows.Forms.DataGridView();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEditBook = new System.Windows.Forms.Button();
			this.btnDeleteBook = new System.Windows.Forms.Button();
			this.btnBorrowBook = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvBooksData)).BeginInit();
			this.SuspendLayout();
			// 
			// gvBooksData
			// 
			this.gvBooksData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvBooksData.Location = new System.Drawing.Point(83, 89);
			this.gvBooksData.Name = "gvBooksData";
			this.gvBooksData.RowHeadersWidth = 51;
			this.gvBooksData.RowTemplate.Height = 24;
			this.gvBooksData.Size = new System.Drawing.Size(605, 239);
			this.gvBooksData.TabIndex = 0;
			// 
			// btnAddBook
			// 
			this.btnAddBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddBook.Location = new System.Drawing.Point(83, 351);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(161, 40);
			this.btnAddBook.TabIndex = 1;
			this.btnAddBook.Text = "Add New Book";
			this.btnAddBook.UseVisualStyleBackColor = true;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 46);
			this.label1.TabIndex = 2;
			this.label1.Text = "BOOKS RECORD";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnEditBook
			// 
			this.btnEditBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditBook.Location = new System.Drawing.Point(304, 351);
			this.btnEditBook.Name = "btnEditBook";
			this.btnEditBook.Size = new System.Drawing.Size(161, 40);
			this.btnEditBook.TabIndex = 3;
			this.btnEditBook.Text = "Edit Book";
			this.btnEditBook.UseVisualStyleBackColor = true;
			this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
			// 
			// btnDeleteBook
			// 
			this.btnDeleteBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteBook.Location = new System.Drawing.Point(518, 351);
			this.btnDeleteBook.Name = "btnDeleteBook";
			this.btnDeleteBook.Size = new System.Drawing.Size(161, 40);
			this.btnDeleteBook.TabIndex = 4;
			this.btnDeleteBook.Text = "Delete Book";
			this.btnDeleteBook.UseVisualStyleBackColor = true;
			this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
			// 
			// btnBorrowBook
			// 
			this.btnBorrowBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrowBook.Location = new System.Drawing.Point(83, 398);
			this.btnBorrowBook.Name = "btnBorrowBook";
			this.btnBorrowBook.Size = new System.Drawing.Size(605, 40);
			this.btnBorrowBook.TabIndex = 5;
			this.btnBorrowBook.Text = "Borrow A Book";
			this.btnBorrowBook.UseVisualStyleBackColor = true;
			this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
			// 
			// ManageBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBorrowBook);
			this.Controls.Add(this.btnDeleteBook);
			this.Controls.Add(this.btnEditBook);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.gvBooksData);
			this.Name = "ManageBooks";
			this.Text = "ManageBooks";
			this.Load += new System.EventHandler(this.ManageBooks_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvBooksData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvBooksData;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEditBook;
		private System.Windows.Forms.Button btnDeleteBook;
		private System.Windows.Forms.Button btnBorrowBook;
	}
}