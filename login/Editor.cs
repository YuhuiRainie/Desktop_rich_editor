using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Editor : Form
    {
        List<string> user = new List<string>();
        List<string> userType = new List<string>();
        string  type;
    
        public Editor()
        {
            InitializeComponent();
        }

        private void ToolNew_Click(object sender, EventArgs e)
        {
            // when user click new, the system will creat a new page
            Editor Newfunction = new Editor();
            Newfunction.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            // logout to the login page
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            // go to about form
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Stream myStream = null;
           // open a file with all txt files type
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Open Text File";
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*t";
            OpenFileDialog.InitialDirectory = @"C:\";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = OpenFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string filename = OpenFileDialog.FileName;
                            // load all lines to richTextBox 
                            string[] filelines = System.IO.File.ReadAllLines(filename);
                            for (int loopvar = 0; loopvar < filelines.Length; loopvar++)
                            {
                                //append the file and load all lines into RichTextBox until the last line
                                richTextBox1.AppendText(filelines[loopvar]);
                            }   
                        }
                    }
                   
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ee.Message);
                }
            }
        }

        private void BuiltFile_Click(object sender, EventArgs e)
        {
            Editor Newfunction = new Editor();
            Newfunction.Show();
        }
        public int SearchIndex(string searchItem)
        {
            // search the index of the user name in user list
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

        private void Editor_Load(object sender, EventArgs e)
        {
            //get username value from previous login page
            string UserName = login.passingValue;
            //give this value to toolStripeLable to appear the username in it
            toolStripLabel2.Text = "User Name : "+ UserName;

            //load the login.txt file and add the username to user list. Add user type to UserType list
            StreamReader file = new StreamReader("login.txt");
            string lines = "";
            while ((lines = file.ReadLine()) != null)
            {

                string[] fields = lines.Split(',');
                user.Add(fields[0]);
                userType.Add(fields[2]);

            }
            file.Close();
            //search the username's type
            type=userType[SearchIndex(UserName)];

            // if user type is View then only enable the open file button
            if (type.Equals("View"))
            {
                BuiltFile.Enabled = false;
                SaveFile.Enabled = false;
                SaveAs.Enabled = false;
                Edit.Enabled = false;
                ToolNew.Enabled = false;
                ToolSave.Enabled = false;
                ToolSaveAs.Enabled = false;
                ToolBold.Enabled = false;
                ToolItalic.Enabled = false;
                ToolUderline.Enabled = false;
                Size.Enabled = false;
                ToolCut.Enabled = false;
                ToolPaste.Enabled = false;
                ToolCopy.Enabled = false;
                richTextBox1.Enabled = false;
            }
            else
            {
                ToolOpen.Enabled = true;
                OpenFile.Enabled = true;
                BuiltFile.Enabled = true;
                SaveFile.Enabled = true;
                SaveAs.Enabled = true;
                Edit.Enabled = true;
                ToolNew.Enabled = true;
                ToolSave.Enabled = true;
                ToolSaveAs.Enabled = true;
                ToolBold.Enabled = true;
                ToolItalic.Enabled = true;
                ToolUderline.Enabled = true;
                Size.Enabled = true;
                ToolCut.Enabled = true;
                ToolPaste.Enabled = true;
                ToolCopy.Enabled = true;
                richTextBox1.Enabled = true;
            }


        }

        //same with OpenFile_click, so I will not comment on this part repeatively
        private void ToolOpen_Click(object sender, EventArgs e)
        {
            //open a new file, clear the current context in the RichTextBox
            richTextBox1.Clear();
            Stream myStream = null;
            //open all type of Text file 
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Open Text File";
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog.InitialDirectory = @"C:\";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = OpenFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string filename = OpenFileDialog.FileName;

                            StreamReader streamReader = new StreamReader(OpenFileDialog.FileName);
                            richTextBox1.Rtf = streamReader.ReadToEnd();
                           // string[] filelines = System.IO.File.ReadAllLines(richTextBox1.Text=filename);
                           /* for (int loopvar = 0; loopvar < filelines.Length; loopvar++)
                            {
                                richTextBox1.AppendText(filelines[loopvar]);
                            }*/
                        
                        }
                      
                    }
                   
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ee.Message);
                }
            }
        }
        //save function only can save what the user wrote into an existed file
        private void SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // save what user has typed into .rtf
                saveFileDialog.Filter = "Rich Text Format|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // write all context in richTextBox to the file that the user clicked
                    using (Stream stream = System.IO.File.Open(saveFileDialog.FileName, FileMode.Open))
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The file cannot be found! please find a existed file!");
            }
        }
        // savaAs function will creat a new file with what user has typed in richTextBox
        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format|*.rtf";// save to.rft document
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //creat a new file and put what the user has write in the richTextBox
                using (Stream stream = System.IO.File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(richTextBox1.Rtf);
                }
            }
        }
        

        //save function only save context in exsited
        private void ToolSave_Click(object sender, EventArgs e)
        {
            try
            {

                     SaveFileDialog saveFileDialog = new SaveFileDialog();
                     saveFileDialog.Filter = "Rich Text Format|*.rtf";
                     if (saveFileDialog.ShowDialog() == DialogResult.OK)
                     {
                         using (Stream stream = System.IO.File.Open(saveFileDialog.FileName, FileMode.Open))
                         using (StreamWriter sw = new StreamWriter(stream))
                         {
                             sw.Write(richTextBox1.Text);
                         }
                     }
                }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The file cannot be found! please find a existed file!");
            }

        }
        //It is same as SaveAS_Click. Please see the comment in that method
        private void ToolSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = System.IO.File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }
        //cut the selected context in richTextBox
        private void Cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        // copy the selected context in richTextBox
        private void Copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        // Paste what user has selected in the selected place
        private void Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //same with cut_Click
        private void ToolCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //same with Copy_Click
        private void ToolCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        // change selected words'size
        private void Size_Click(object sender, EventArgs e)
        {
            try
            {
                // get the current selected words' style
                FontStyle style = richTextBox1.SelectionFont.Style;
                //after the user select the size number, it will not be null
                if (this.Size.Text != "")
                {
                    //convert the selected size number and give to Font function
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
                        Convert.ToInt32(this.Size.SelectedItem),
                        richTextBox1.SelectionFont.Style);

                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
               
            }
            catch (NullReferenceException)
            {
                // there is a auto-generated "" null space at the end of fist line, user should not select including this 
                MessageBox.Show("Please do not select the last space at the end of the line");
            } 
        }


    


        private void ToolBold_Click(object sender, EventArgs e)
        {
            try
            {
                // get current selected words' style
                FontStyle style = richTextBox1.SelectionFont.Style;
               
                // check if it is Bold alread
                if (richTextBox1.SelectionFont.Bold)
                {
                    //if it is Bold already, it will remove the bold style
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    //else combine with bold font
                    style |= FontStyle.Bold;

                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
            catch (NullReferenceException)
            {
                // there is a auto-generated "" null space at the end of fist line, user should not select including this 
                MessageBox.Show("Please do not select the last space at the end of the line");
            }
        }

        private void ToolItalic_Click(object sender, EventArgs e)
        {
            try{
                // get current selected words' style
                FontStyle style = richTextBox1.SelectionFont.Style;
                // check if it is Italic alread
                if (richTextBox1.SelectionFont.Italic)
                {
                    //if it is Bold already, it will remove the Italic style
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    // else combine with italic font
                    style |= FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style); }
            catch (NullReferenceException)
            {
                // there is a auto-generated "" null space at the end of fist line, user should not select including this 
                MessageBox.Show("Please do not select the last space at the end of the line");
            }
        }

        private void ToolUderline_Click(object sender, EventArgs e)
        {
            try
            {
                // get current selected words' style
                FontStyle style = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Underline)
                { 
                    // check if it is underlined alread
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    // else combine with underline font
                    style |= FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
            catch (NullReferenceException)
            {
                // there is a auto-generated "" null space at the end of fist line, user should not select including this 
                MessageBox.Show("Please do not select the last space at the end of the line");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
