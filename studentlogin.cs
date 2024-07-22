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
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var context = new SchoolContext())
            {
                var studname1 = textBox1.Text;
                var studpass = textBox2.Text;

                var user1 = new User
                {
                    StudentName = studname1,

                    StudentPassword = studpass
                };

                var context1 = new SchoolContext();




                context.Add<User>(user1);

                //save data to the database tables
                context.SaveChanges();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var studname3 = textBox1.Text;
                var studpass3 = textBox2.Text;



                var context1 = new SchoolContext();
                var result = context.Users
                             .Where(s => s.StudentName == studname3)
                              .Select(s => s.StudentPassword).FirstOrDefault();
                if (result != null && result == studpass3)
                {
                    MessageBox.Show("Successfull login");
                    new Buy_book_student().Show();
                }
                else
                {
                    MessageBox.Show("Successfull failed");
                }




            }
        }
    }
}
