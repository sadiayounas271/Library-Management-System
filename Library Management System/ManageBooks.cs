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
	public partial class ManageBooks : Form
	{
		private LibraryManagementStudioEntities db;
		public ManageBooks()
		{
			db = new LibraryManagementStudioEntities();
			InitializeComponent();
			PopulateGrid();
			if(Utils.isAdmin)
			{
				

			}	
		}

		public void PopulateGrid()
		{
			var booksData = db.Books.Select(q => new
			{
				Id = q.Id,
				BookName = q.BookName,
				Edition = q.Edition,
				Category = q.Category,
				Purchased = q.BookPurchasedDate
			}).ToList();
			
			gvBooksData.DataSource = booksData;
			gvBooksData.Columns[1].HeaderText = "Book Name";
			gvBooksData.Columns[0].Visible= false;
		}
		private void btnAddBook_Click(object sender, EventArgs e)
		{
			var addBook = new AddEditBook(this);
			addBook.MdiParent = this.MdiParent;
			addBook.Show();
		}

		private void btnEditBook_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)gvBooksData.SelectedRows[0].Cells["Id"].Value;
				Book book = db.Books.FirstOrDefault(x => x.Id == id);
				if (book == null)
				{
					MessageBox.Show("No any ID selected!");
				}
				else
				{
					var addBook = new AddEditBook(this, id);
					addBook.MdiParent = this.MdiParent;
					addBook.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDeleteBook_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)gvBooksData.SelectedRows[0].Cells["Id"].Value;
				Book book = db.Books.FirstOrDefault(x => x.Id == id);
				if (book == null)
				{
					MessageBox.Show("No any ID selected!");
				}
				else
				{
					db.Books.Remove(book);
					db.SaveChanges();
					MessageBox.Show("Data Deleted");
					PopulateGrid();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ManageBooks_Load(object sender, EventArgs e)
		{
			if (Utils.isAdmin == false)
			{
				btnAddBook.Visible = false;
				btnEditBook.Visible = false;
				btnDeleteBook.Visible = false;
			}
			else
			{
			//	btnBorrowBook.Visible = false;
			}	
		}

		private void btnBorrowBook_Click(object sender, EventArgs e)
		{
			if(!Utils.FormIsOpen(nameof(BorrowABook)))
				{
				var borrowBook = new BorrowABook();
				borrowBook.MdiParent = this.MdiParent;
				borrowBook.Show();
			}
		}
	}
}
