using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryDemo
{
    public partial class search : Form
    {
        public string searchitem;
        public search(string search)
        {
            InitializeComponent();
            searchitem = search;
        }

        private void search_Load(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {

                var books = (from x in context.Books where x.BookName == searchitem select new {x.BookName,x.BookCount}).ToList();
                if (books.Any())
                {
                    searchresult.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Book not found");
                }
            }
        }

        private void searchresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
