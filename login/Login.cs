using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class login : Form
    {
        public static string passingValue;
        List<string> user = new List<string>();
        List<string> pass = new List<string>();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        { 
            //onece opened the login page, then start to load login.txt
            try
            {
                StreamReader file = new StreamReader("login.txt");
                string lines = "";
                while ((lines = file.ReadLine()) != null)
                {
                    //input the username and password in the login.txt to user and pass list
                    string[] fields = lines.Split(',');
                    user.Add(fields[0]);
                    pass.Add(fields[1]);

                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("login.txt is missing!");
            }



        }
        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser Register = new NewUser();
            Register.Show();

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static bool Validation<T>(T value1, T value2)
        {
            //compare two values are same or not
            return value1.Equals(value2);
        }

        public int SearchIndex(string searchItem)
        {
            // search the username that the user input in the textbox and find the index in user list
            int userIndex = 0;
            foreach (string username in user)
            {
                if (user.Contains(searchItem))
                {
                    userIndex = user.IndexOf(searchItem);

                }

                return userIndex;

            }
            return userIndex;
        }

        private void Yes_Click_1(object sender, EventArgs e)
        {
            // username and password textbox should not be null
            if (!(textBox1.Text.ToString() is null || textBox2.Text.ToString() is null))
            {
                int userIndex = SearchIndex(textBox1.Text.ToString());

                // compare if username is same
                if (Validation<string>(textBox1.Text.ToString(), user[userIndex].ToString()))
                {
                    //compare password for this username is same
                    if (Validation<string>(textBox2.Text.ToString(), pass[userIndex].ToString()))
                    {
                        passingValue=textBox1.Text.ToString();
                        this.Hide();
                        Form editor = new Editor();
                        editor.Show();
                        MessageBox.Show("Connect to system successfully");
                       
                    }
                    else
                    {
                        // warming for input wrong password or username
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show("Password is incorrect!", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Password cannot be null!", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string password = textBox1.Text;
        }

        
    }
}
