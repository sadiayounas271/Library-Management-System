using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	public partial class AddEditBook : Form
	{
		private ManageBooks _manageBooks;
		private LibraryManagementStudioEntities db;
		bool isEditable;
		public AddEditBook(ManageBooks manageBooks)
		{
			isEditable = false;
			InitializeComponent();
			labelTop.Text = "Add New Book";
			db = new LibraryManagementStudioEntities();
			_manageBooks = manageBooks;
		}
		private int bookIDToEdit;
		Book bookToEdit;
		public AddEditBook(ManageBooks manageBooks, int id)
		{
			bookIDToEdit = id;
			isEditable = true;
			InitializeComponent();
			labelTop.Text = "Edit Book Data";
			db = new LibraryManagementStudioEntities();
			_manageBooks = manageBooks;
			bookToEdit = db.Books.FirstOrDefault(x => x.Id == id);
			PopulateFindRecord(bookToEdit);
		}
		void PopulateFindRecord(Book book)
		{
			txtBookName.Text = book.BookName;
			txtEdition.Text = book.Edition.ToString();
			txtCategory.Text = book.Category;
			book.BookPurchasedDate = book.BookPurchasedDate;
		}
		private void btn_Save_Click(object sender, EventArgs e)
		{
			bool isValid = true;
			var errorMessage = "";
			try
			{
				string _bookName = txtBookName.Text;
				int _edition;
				string _category = txtCategory.Text;
				DateTime _purchasingDate = dtPurchasing.Value;

				if (string.IsNullOrWhiteSpace(_bookName) || string.IsNullOrEmpty(_category))
				{
					errorMessage = "Enter missing values\n";
					isValid = false;
				}
				if (!int.TryParse(txtEdition.Text, out _edition))
				{
					errorMessage += "Enter edition in integers\n";
					isValid = false;
				}

				if (isValid)
				{
					if (isEditable == false)
					{
						var book = new Book();
						AssignData(book);
						db.Books.Add(book);
					}
					else
					{
						AssignData(bookToEdit);
					}
					void AssignData(Book book)
					{
						book.BookName = _bookName;
						book.Edition = _edition;
						book.Category = _category;
						book.BookPurchasedDate = _purchasingDate;
					}
				
					db.SaveChanges();
					MessageBox.Show("Data Updated!");
					Close();
					_manageBooks.PopulateGrid();
				}
				else
				{
					MessageBox.Show(errorMessage);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
