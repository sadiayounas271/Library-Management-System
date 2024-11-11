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
	public partial class BorrowABook : Form
	{
		private LibraryManagementStudioEntities db;
		public BorrowABook()
		{
			db = new LibraryManagementStudioEntities();
			InitializeComponent();
			PopulateComboBox();
		}
	void PopulateComboBox()
		{
			var books = db.Books.Select(
				q => new
				{
					q.Id,
					q.BookName,
				}).ToList();
			
			comboBoxAllBooks.DataSource = books;
			comboBoxAllBooks.DisplayMember = "BookName";
			comboBoxAllBooks.ValueMember= "Id";
		}

		private void btn_SaveDetails_Click(object sender, EventArgs e)
		{
			try
			{
				int _userId = Utils.UserId;
				int bookId = (int)comboBoxAllBooks.SelectedValue;
				DateTime _dtBorrowed = dtBorrowed.Value;
				DateTime _dtReturned = dtReturn.Value;

				var borrowedData = new BookBorrowedDetail();
				borrowedData.UserId= _userId;
				borrowedData.BookId= bookId;
				borrowedData.BorrowedDate= _dtBorrowed;
				borrowedData.ReturnDate= _dtReturned;	

				db.BookBorrowedDetails.Add(borrowedData);
				db.SaveChanges();
				MessageBox.Show("Your Record Entered in DB");
				Close();

			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
