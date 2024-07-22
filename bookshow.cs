using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDemo
{
    public partial class bookshow : Form
    {
        public bookshow()
        {
            InitializeComponent();
        }

        private void bookshow_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var books = (from x in context.Books where x.isDelete == 0 select new { x.BookName, x.BookCount }).ToList();
                dataGridView1.DataSource = books;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search obj = new search(textBox1.Text);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new buybook().Show();
        }
    }
}
