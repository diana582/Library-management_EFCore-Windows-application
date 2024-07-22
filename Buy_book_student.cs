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
    public partial class Buy_book_student : Form
    {
        public Buy_book_student()
        {
            InitializeComponent();
        }

        private void Buy_book_student_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var books = (from x in context.Books where x.isDelete == 0 select new { x.BookName, x.BookCount }).ToList();
                dataGridView1.DataSource = books;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new buybook().Show();
        }
    }
}
