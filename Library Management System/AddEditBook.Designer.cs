namespace Library_Management_System
{
	partial class AddEditBook
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
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.labelTop = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtEdition = new System.Windows.Forms.TextBox();
			this.dtPurchasing = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancel.Location = new System.Drawing.Point(442, 402);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(150, 36);
			this.btn_Cancel.TabIndex = 12;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Save.Location = new System.Drawing.Point(214, 402);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(150, 36);
			this.btn_Save.TabIndex = 11;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// labelTop
			// 
			this.labelTop.AutoSize = true;
			this.labelTop.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTop.Location = new System.Drawing.Point(345, 9);
			this.labelTop.Name = "labelTop";
			this.labelTop.Size = new System.Drawing.Size(113, 46);
			this.labelTop.TabIndex = 10;
			this.labelTop.Text = "Label";
			this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtBookName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtEdition, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtCategory, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.dtPurchasing, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(125, 58);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 326);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 26);
			this.label6.TabIndex = 11;
			this.label6.Text = "Purchasing Date";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(281, 246);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(202, 22);
			this.txtCategory.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 26);
			this.label4.TabIndex = 2;
			this.label4.Text = "Book Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Edition";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Category";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(281, 3);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(202, 22);
			this.txtBookName.TabIndex = 3;
			// 
			// txtEdition
			// 
			this.txtEdition.Location = new System.Drawing.Point(281, 84);
			this.txtEdition.Name = "txtEdition";
			this.txtEdition.Size = new System.Drawing.Size(202, 22);
			this.txtEdition.TabIndex = 4;
			// 
			// dtPurchasing
			// 
			this.dtPurchasing.Location = new System.Drawing.Point(281, 165);
			this.dtPurchasing.Name = "dtPurchasing";
			this.dtPurchasing.Size = new System.Drawing.Size(272, 22);
			this.dtPurchasing.TabIndex = 12;
			// 
			// AddEditBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.labelTop);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AddEditBook";
			this.Text = "AddEditBook";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Label labelTop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.TextBox txtEdition;
		private System.Windows.Forms.DateTimePicker dtPurchasing;
	}
}