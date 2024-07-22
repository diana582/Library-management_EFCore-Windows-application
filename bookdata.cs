using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDemo
{
    public partial class bookdata : Form
    {
        public bookdata()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {

                var bookname = textBox2.Text;
                var bookcount = textBox3.Text;

                var existingBook = context.Books.FirstOrDefault(b => b.BookName == bookname);
                if (existingBook != null)
                {
                    MessageBox.Show("A book with this name already exists. Please enter a unique book name.");
                    return;
                }

                var book1 = new Book
                {
                    BookName = bookname,
                    BookCount = Convert.ToInt32(bookcount)
                };


                context.Add(book1);
                MessageBox.Show("Enter a book name that is to be edited");
                context.SaveChanges();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var bookname1 = textBox2.Text;
                var bookcount1 = textBox3.Text;


                if (string.IsNullOrEmpty(bookname1))
                {
                    MessageBox.Show("Enter a book name that is to be edited");
                    return;
                }


                var book = context.Books.FirstOrDefault(a => a.BookName == bookname1);
                if (book == null)
                {
                    MessageBox.Show("Book not found");
                    return;
                }


                if (int.TryParse(bookcount1, out int newCount))
                {
                    if (newCount == 0)
                    {

                        context.Books.Remove(book);
                        MessageBox.Show("Book deleted successfully");
                    }
                    else
                    {

                        book.BookCount = newCount;
                        MessageBox.Show("Book count updated successfully");
                    }

                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Invalid book count. Please enter a numeric value.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var bookname1 = textBox2.Text;
                var bookcount1 = textBox3.Text;
                var book = context.Books.FirstOrDefault(a => a.BookName == bookname1);
                book.isDelete = Convert.ToInt32(1);
                context.SaveChanges();

                MessageBox.Show("Book deleted successfully");

            }

        }

        private void bookdata_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new bookshow().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
