namespace Library_Management_System
{
	partial class SignUp
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
			this.btn_CreateAccount = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRollNumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btn_HaveAccount = new System.Windows.Forms.Button();
			this.radioStudent = new System.Windows.Forms.RadioButton();
			this.radioTeacher = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_CreateAccount
			// 
			this.btn_CreateAccount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CreateAccount.Location = new System.Drawing.Point(245, 356);
			this.btn_CreateAccount.Name = "btn_CreateAccount";
			this.btn_CreateAccount.Size = new System.Drawing.Size(285, 43);
			this.btn_CreateAccount.TabIndex = 7;
			this.btn_CreateAccount.Text = "Create Account";
			this.btn_CreateAccount.UseVisualStyleBackColor = true;
			this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(205, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(378, 46);
			this.label1.TabIndex = 5;
			this.label1.Text = "Create a new account";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.txtConfirmPassword, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtRollNumber, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioTeacher, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioStudent, 0, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 54);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 296);
			this.tableLayoutPanel1.TabIndex = 4;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(301, 199);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(202, 22);
			this.txtConfirmPassword.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 26);
			this.label6.TabIndex = 11;
			this.label6.Text = "Phone Number";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(301, 150);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(202, 22);
			this.txtPassword.TabIndex = 8;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(301, 101);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(202, 22);
			this.txtPhoneNumber.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 26);
			this.label4.TabIndex = 2;
			this.label4.Text = "Roll Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Email Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(187, 26);
			this.label5.TabIndex = 10;
			this.label5.Text = "Confirm Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password";
			// 
			// txtRollNumber
			// 
			this.txtRollNumber.Location = new System.Drawing.Point(301, 3);
			this.txtRollNumber.Name = "txtRollNumber";
			this.txtRollNumber.Size = new System.Drawing.Size(202, 22);
			this.txtRollNumber.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(301, 52);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(202, 22);
			this.txtEmail.TabIndex = 4;
			// 
			// btn_HaveAccount
			// 
			this.btn_HaveAccount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_HaveAccount.Location = new System.Drawing.Point(213, 405);
			this.btn_HaveAccount.Name = "btn_HaveAccount";
			this.btn_HaveAccount.Size = new System.Drawing.Size(372, 43);
			this.btn_HaveAccount.TabIndex = 8;
			this.btn_HaveAccount.Text = "Already have an account?";
			this.btn_HaveAccount.UseVisualStyleBackColor = true;
			this.btn_HaveAccount.Click += new System.EventHandler(this.btn_HaveAccount_Click);
			// 
			// radioStudent
			// 
			this.radioStudent.AutoSize = true;
			this.radioStudent.Checked = true;
			this.radioStudent.Location = new System.Drawing.Point(3, 248);
			this.radioStudent.Name = "radioStudent";
			this.radioStudent.Size = new System.Drawing.Size(73, 20);
			this.radioStudent.TabIndex = 13;
			this.radioStudent.Text = "Student";
			this.radioStudent.UseVisualStyleBackColor = true;
			// 
			// radioTeacher
			// 
			this.radioTeacher.AutoSize = true;
			this.radioTeacher.Location = new System.Drawing.Point(301, 248);
			this.radioTeacher.Name = "radioTeacher";
			this.radioTeacher.Size = new System.Drawing.Size(79, 20);
			this.radioTeacher.TabIndex = 14;
			this.radioTeacher.Text = "Teacher";
			this.radioTeacher.UseVisualStyleBackColor = true;
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_HaveAccount);
			this.Controls.Add(this.btn_CreateAccount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SignUp";
			this.Text = "SignUp Page";
			this.Load += new System.EventHandler(this.SignUp_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_CreateAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRollNumber;
		private System.Windows.Forms.Button btn_HaveAccount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.RadioButton radioStudent;
		private System.Windows.Forms.RadioButton radioTeacher;
	}
}