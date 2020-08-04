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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void Submite_Click(object sender, EventArgs e)
        {
            //load login.txt and open it to write new user information
            StreamWriter NewUser = new StreamWriter("login.txt",true);
            Birth.Format = DateTimePickerFormat.Custom; 
            Birth.CustomFormat= "dd-MM-yyyy";// change the birth format
            string birth = Birth.Value.ToString(Birth.CustomFormat);
            string type = UserType.GetItemText(UserType.SelectedItem);
            
            
          // write new user information to login.txt
             NewUser.WriteLine();
             NewUser.Write(RegisterUsername.Text + "," + RegisterPassword.Text + "," + type + "," + FirstName.Text + "," + LastName.Text + "," + birth);
             NewUser.Close();
         // go to main edit page
            MessageBox.Show("You can login to the system now");
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void RegisterUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Birth_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
