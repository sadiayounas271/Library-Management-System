namespace Library_Management_System
{
	partial class ViewDetails
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
			this.gvBorrowedDetails = new System.Windows.Forms.DataGridView();
			this.lblTop = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvBorrowedDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// gvBorrowedDetails
			// 
			this.gvBorrowedDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvBorrowedDetails.Location = new System.Drawing.Point(24, 67);
			this.gvBorrowedDetails.Name = "gvBorrowedDetails";
			this.gvBorrowedDetails.RowHeadersWidth = 51;
			this.gvBorrowedDetails.RowTemplate.Height = 24;
			this.gvBorrowedDetails.Size = new System.Drawing.Size(736, 348);
			this.gvBorrowedDetails.TabIndex = 0;
			this.gvBorrowedDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBorrowedDetails_CellContentClick);
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(190, 9);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(113, 46);
			this.lblTop.TabIndex = 11;
			this.lblTop.Text = "Label";
			this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ViewDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTop);
			this.Controls.Add(this.gvBorrowedDetails);
			this.Name = "ViewDetails";
			this.Text = "ViewDetails";
			((System.ComponentModel.ISupportInitialize)(this.gvBorrowedDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvBorrowedDetails;
		private System.Windows.Forms.Label lblTop;
	}
}