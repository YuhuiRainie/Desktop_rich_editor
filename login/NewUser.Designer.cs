namespace login
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterUsername = new System.Windows.Forms.TextBox();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.Submite = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // RegisterUsername
            // 
            this.RegisterUsername.Location = new System.Drawing.Point(234, 88);
            this.RegisterUsername.Name = "RegisterUsername";
            this.RegisterUsername.Size = new System.Drawing.Size(100, 25);
            this.RegisterUsername.TabIndex = 1;
            this.RegisterUsername.TextChanged += new System.EventHandler(this.RegisterUsername_TextChanged);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(234, 139);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '*';
            this.RegisterPassword.Size = new System.Drawing.Size(100, 25);
            this.RegisterPassword.TabIndex = 2;
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(234, 207);
            this.RePassword.Name = "RePassword";
            this.RePassword.PasswordChar = '*';
            this.RePassword.Size = new System.Drawing.Size(100, 25);
            this.RePassword.TabIndex = 3;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(234, 274);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 25);
            this.FirstName.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(234, 327);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 25);
            this.LastName.TabIndex = 5;
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(234, 381);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(200, 25);
            this.Birth.TabIndex = 6;
            this.Birth.ValueChanged += new System.EventHandler(this.Birth_ValueChanged);
            // 
            // UserType
            // 
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "View",
            "Edite"});
            this.UserType.Location = new System.Drawing.Point(234, 437);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(121, 23);
            this.UserType.TabIndex = 7;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.UserType_SelectedIndexChanged);
            // 
            // Submite
            // 
            this.Submite.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submite.Location = new System.Drawing.Point(80, 524);
            this.Submite.Name = "Submite";
            this.Submite.Size = new System.Drawing.Size(97, 38);
            this.Submite.TabIndex = 8;
            this.Submite.Text = "Submit";
            this.Submite.UseVisualStyleBackColor = true;
            this.Submite.Click += new System.EventHandler(this.Submite_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(329, 524);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 38);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username.Location = new System.Drawing.Point(73, 91);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(79, 15);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(76, 149);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 15);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Re_Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(67, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(73, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(53, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(89, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "User Type";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 587);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submite);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.RegisterUsername);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegisterUsername;
        private System.Windows.Forms.TextBox RegisterPassword;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.DateTimePicker Birth;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Button Submite;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}