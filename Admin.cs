using System.Diagnostics;

namespace LibraryDemo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var username2 = textBox1.Text;
                var password2 = textBox2.Text;

               

                var context1 = new SchoolContext();
                var result = context.Logins
                             .Where(s => s.username == username2)
                              .Select(s => s.password).FirstOrDefault();
                if (result != null && result == password2)
                {
                    MessageBox.Show("Successfull login");
                    new bookdata().Show();
                }
                else
                {
                    MessageBox.Show("Successfull failed");
                }


               

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            




         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var username1 = textBox1.Text;
                var password2 = textBox2.Text;

                var user1 = new login { username = username1,
                
                password = password2};

                var context1 = new SchoolContext();
                


                //add entitiy to the context
                 context.Add<login>(user1);

                //save data to the database tables
                 context.SaveChanges();

                //retrieve all the students from the database

            }
        }
    }
}
