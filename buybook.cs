using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryDemo
{
    public partial class buybook : Form
    {
        public buybook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                

                using (var context = new SchoolContext())
                {

                    var bookname1 = textBox1.Text;


                    var context1 = new SchoolContext();
                    

                var book = context.Books.FirstOrDefault(b => b.BookName == bookname1);

               
                if (book != null)
                {
                   
                    if (book.BookCount > 0)
                    {
                        
                        book.BookCount--;

                       
                        context.SaveChanges();

                        MessageBox.Show("Book purchased successfully. Remaining count: " + book.BookCount);
                    }
                    else
                    {
                        MessageBox.Show("No more copies of this book are available.");
                    }
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }

            }


        }
    }
}
