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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
			var login = new LOGIN();
			login.MdiParent = this;
			login.Show();
		}

		public bool isUserLogIn()
		{
			if(Utils.UserId==0)
			{
				if (!Utils.FormIsOpen(nameof(LOGIN)))
				{
					var login = new LOGIN();
					login.MdiParent = this;
					login.Show();
					MessageBox.Show("You're not logged In");
				}
				return false;
			}
			return true;
		}
		private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (isUserLogIn())
			{
				if (!Utils.FormIsOpen(nameof(ManageBooks)))
				{
					var manageBooks = new ManageBooks();
					manageBooks.MdiParent = this;
					manageBooks.Show();
				}
			}
		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!Utils.FormIsOpen(nameof(LOGIN)))
			{
				var login = new LOGIN();
				login.MdiParent = this;
				login.Show();
			}
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (isUserLogIn())
			{
				if (!Utils.FormIsOpen(nameof(ViewDetails)))
				{
					var details = new ViewDetails();
					details.MdiParent = this;
					details.Show();
				}
			}
		}
	}
}
