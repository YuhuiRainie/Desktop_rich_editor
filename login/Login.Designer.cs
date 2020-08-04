using System;

namespace login
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Yes = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(182, 173);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 2;
            this.Yes.Text = "Login";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click_1);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(51, 173);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 3;
            this.quit.Text = "Exit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(310, 173);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(92, 23);
            this.Register.TabIndex = 4;
            this.Register.Text = "New User";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(48, 65);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 15);
            this.username.TabIndex = 5;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(51, 114);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(79, 15);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(100, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(264, 25);
            this.title.TabIndex = 7;
            this.title.Text = "Text Editor System";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 208);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "Text Editor System";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox2;
    }
}

