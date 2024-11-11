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
	public partial class ViewDetails : Form
	{
		private LibraryManagementStudioEntities db;
		public ViewDetails()
		{
			db = new LibraryManagementStudioEntities();
			InitializeComponent();
			PopulateGrid();
		}
		void PopulateGrid()
		{
			if (Utils.isAdmin)
			{
				lblTop.Text = "View All Users Details";
				ViewAllUsers();
			}
			else
			{
				lblTop.Text = "View Mine Details";
				ViewMineDetails();
			}

		}

		void ViewAllUsers()
		{
			try
			{
				var borrowedDetails = db.BookBorrowedDetails.Select(q =>
			new
			{
				q.UserId,
				q.BookId,
				q.BorrowedDate,
				q.ReturnDate,
			}).ToList();

				var users = db.Users.ToList();
				var books = db.Books.ToList();

				var getAllUsersDetails = borrowedDetails.Select(b => new
				{
					EmailAddress = users.FirstOrDefault(u => u.Id == b.UserId)?.Email,
					BookName = books.FirstOrDefault(q => q.Id == b.BookId)?.BookName,
					b.BorrowedDate,
					b.ReturnDate,
				}).ToList();


				gvBorrowedDetails.DataSource = getAllUsersDetails;
				gvBorrowedDetails.Columns[0].HeaderText = "User Email Id";
				gvBorrowedDetails.Columns[1].HeaderText = "Book Name";
			}
			catch { }
		}

		void ViewMineDetails()
		{
			try
			{
				var myIdExist = db.BookBorrowedDetails.FirstOrDefault(q=>q.UserId==Utils.UserId);
				if (myIdExist == null)
				{
					MessageBox.Show("No Record Found");
				}
				else
				{
					var borrowedDetails = db.BookBorrowedDetails
						 .Where(q => q.UserId == Utils.UserId)
		 	.Select(q => new
			 {
				 q.UserId,
				 q.BookId,
				 q.BorrowedDate,
				 q.ReturnDate,
			 }).ToList();

					var users = db.Users.ToList();
					var books = db.Books.ToList();

					var getAllUsersDetails = borrowedDetails.Select(b => new
					{
						EmailAddress = users.FirstOrDefault(u => u.Id == b.UserId)?.Email,
						BookName = books.FirstOrDefault(q => q.Id == b.BookId)?.BookName,
						b.BorrowedDate,
						b.ReturnDate,
					}).ToList();


					gvBorrowedDetails.DataSource = getAllUsersDetails;
					gvBorrowedDetails.Columns[0].HeaderText = "User Email Id";
					gvBorrowedDetails.Columns[1].HeaderText = "Book Name";

				}
			}
			catch { }
		}
		private void gvBorrowedDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
