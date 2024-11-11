using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	public partial class LOGIN : Form
	{
		private LibraryManagementStudioEntities db;
		public LOGIN()
		{
			db= new LibraryManagementStudioEntities();
			InitializeComponent();
			CreateAdminUser();
		}
		public void CreateAdminUser()
		{
   //       var admin= db.Users.FirstOrDefault(q=>q.Role==Roles.eRoles.Admin.ToString());
			//if (admin == null)
			//{
			//	var adminUser = new User();
			//	adminUser.Email = "admin@gmail.com";
			//	adminUser.PhoneNumber = "123456789";
			//	adminUser.Role = Roles.eRoles.Admin.ToString();
			//	adminUser.Password = Utils.HashPassword("Admin123");

			//	db.Users.Add(adminUser);
			//	db.SaveChanges();
			//}
		}
		private void btn_SignUp_Click(object sender, EventArgs e)
		{
			var signUp = new SignUp(this);
			signUp.MdiParent = this.MdiParent;
			signUp.Show();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			var email = txtEmail.Text;
			var password = Utils.HashPassword(txtPassword.Text);

			var user = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

			if (user != null)
			{
				Utils.UserId = user.Id;
				string admin = Roles.eRoles.Admin.ToString();
				Utils.isAdmin= user.Role == Roles.eRoles.Admin.ToString()?  true : false;

				Close();
			}
			else
			{
				MessageBox.Show("Invalid Credentials");
			}

		}
	}
}
