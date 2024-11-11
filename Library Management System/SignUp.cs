using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	public partial class SignUp : Form
	{
		private LibraryManagementStudioEntities db;
		private LOGIN _login;
		public SignUp(LOGIN login)
		{
			db = new LibraryManagementStudioEntities();
			_login = login;
			_login.Hide();
			InitializeComponent();
		}
		 bool IsValidEmail(string email)
		{
			// Regular expression for validating an email address
			string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			return Regex.IsMatch(email, pattern);
		}
		private void btn_CreateAccount_Click(object sender, EventArgs e)
		{
			try
			{
				var errorMessage = "";
				bool isValid = true;

				string _rollNumber = txtRollNumber.Text;
				string _email = txtEmail.Text;
				string _phoneNumber = txtPhoneNumber.Text;
				string _password = txtPassword.Text;
				string _confirmPassword = txtConfirmPassword.Text;

				if (string.IsNullOrWhiteSpace(_rollNumber) || string.IsNullOrWhiteSpace(_email) ||
					string.IsNullOrWhiteSpace(_phoneNumber) || string.IsNullOrWhiteSpace(_phoneNumber) ||
					string.IsNullOrWhiteSpace(_password) || string.IsNullOrWhiteSpace(_confirmPassword))
				{
					errorMessage = "Please enter complete details!\n";
					isValid = false;
				}

				if (_password != _confirmPassword)
				{
					errorMessage += "Password Mismatch\n";
					isValid = false;
				}
				if(_password.Length<3)
				{
					errorMessage += "Password Length should be atleast 3\n";
					isValid = false;
				}	
				if(!IsValidEmail(_email))
				{
					errorMessage += "Email format not correct!\n";
					isValid = false;
				}
				var foundEmail = db.Users.FirstOrDefault(x=>x.Email==_email);
				if (foundEmail != null) 
					{
					errorMessage = "Email Address already exist!\n";
					isValid= false;
				}

				if (isValid)
				{
					var user = new User();
					user.Id = 1;
					user.Roll_Number = _rollNumber;
					user.Email = _email;
					user.PhoneNumber = _phoneNumber;
					user.Password = Utils.HashPassword(_password);
					if (radioStudent.Checked)
					{
						user.Role = Roles.eRoles.Student.ToString();
					}
					else
					{
						user.Role = Roles.eRoles.Teacher.ToString();
					}

					db.Users.Add(user);
					db.SaveChanges();
					MessageBox.Show("Account Created Successfully!");
					_login.Show();
					Close();

				}
				else
				{
					MessageBox.Show(errorMessage);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_HaveAccount_Click(object sender, EventArgs e)
		{
			Close();
			_login.Show();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void SignUp_Load(object sender, EventArgs e)
		{

		}
	}
}
