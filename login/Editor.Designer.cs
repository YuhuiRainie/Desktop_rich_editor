namespace login
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.BuiltFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolNew = new System.Windows.Forms.ToolStripButton();
            this.ToolOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolSave = new System.Windows.Forms.ToolStripButton();
            this.ToolSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBold = new System.Windows.Forms.ToolStripButton();
            this.ToolItalic = new System.Windows.Forms.ToolStripButton();
            this.ToolUderline = new System.Windows.Forms.ToolStripButton();
            this.Size = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolCut = new System.Windows.Forms.ToolStripButton();
            this.ToolCopy = new System.Windows.Forms.ToolStripButton();
            this.ToolPaste = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuiltFile,
            this.OpenFile,
            this.toolStripSeparator2,
            this.SaveFile,
            this.SaveAs,
            this.toolStripSeparator3,
            this.Logout});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // BuiltFile
            // 
            this.BuiltFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BuiltFile.Image = ((System.Drawing.Image)(resources.GetObject("BuiltFile.Image")));
            this.BuiltFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuiltFile.Name = "BuiltFile";
            this.BuiltFile.ShortcutKeyDisplayString = "Ctrl+N";
            this.BuiltFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.BuiltFile.Size = new System.Drawing.Size(197, 44);
            this.BuiltFile.Text = "New  ";
            this.BuiltFile.Click += new System.EventHandler(this.BuiltFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFile.Size = new System.Drawing.Size(197, 44);
            this.OpenFile.Text = "Open ";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // SaveFile
            // 
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.ShortcutKeyDisplayString = "Ctrl+S";
            this.SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFile.Size = new System.Drawing.Size(197, 44);
            this.SaveFile.Text = "Save  ";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(197, 44);
            this.SaveAs.Text = "Save As";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(197, 44);
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(49, 24);
            this.Edit.Text = "Edit";
            // 
            // Cut
            // 
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeyDisplayString = "Ctrl+X";
            this.Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut.Size = new System.Drawing.Size(198, 36);
            this.Cut.Text = "Cut ";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeyDisplayString = "Ctrl+C";
            this.Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy.Size = new System.Drawing.Size(198, 36);
            this.Copy.Text = "Copy ";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Paste.Name = "Paste";
            this.Paste.ShortcutKeyDisplayString = "Ctrl+V";
            this.Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste.Size = new System.Drawing.Size(198, 36);
            this.Paste.Text = "Paste ";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(56, 24);
            this.Help.Text = "Help";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(146, 26);
            this.About.Text = "About....";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolNew,
            this.ToolOpen,
            this.ToolSave,
            this.ToolSaveAs,
            this.toolStripSeparator1,
            this.ToolBold,
            this.ToolItalic,
            this.ToolUderline,
            this.Size,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 44);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "ToolNew";
            // 
            // ToolNew
            // 
            this.ToolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolNew.Image")));
            this.ToolNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolNew.Name = "ToolNew";
            this.ToolNew.Size = new System.Drawing.Size(29, 41);
            this.ToolNew.Text = "toolStripButton1";
            this.ToolNew.Click += new System.EventHandler(this.ToolNew_Click);
            // 
            // ToolOpen
            // 
            this.ToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolOpen.Image")));
            this.ToolOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolOpen.Name = "ToolOpen";
            this.ToolOpen.Size = new System.Drawing.Size(35, 41);
            this.ToolOpen.Text = "toolStripButton1";
            this.ToolOpen.Click += new System.EventHandler(this.ToolOpen_Click);
            // 
            // ToolSave
            // 
            this.ToolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolSave.Image")));
            this.ToolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSave.Name = "ToolSave";
            this.ToolSave.Size = new System.Drawing.Size(28, 41);
            this.ToolSave.Text = "toolStripButton1";
            this.ToolSave.Click += new System.EventHandler(this.ToolSave_Click);
            // 
            // ToolSaveAs
            // 
            this.ToolSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("ToolSaveAs.Image")));
            this.ToolSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSaveAs.Name = "ToolSaveAs";
            this.ToolSaveAs.Size = new System.Drawing.Size(34, 41);
            this.ToolSaveAs.Text = "toolStripButton1";
            this.ToolSaveAs.Click += new System.EventHandler(this.ToolSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // ToolBold
            // 
            this.ToolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBold.Image = ((System.Drawing.Image)(resources.GetObject("ToolBold.Image")));
            this.ToolBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBold.Name = "ToolBold";
            this.ToolBold.Size = new System.Drawing.Size(30, 41);
            this.ToolBold.Text = "toolStripButton1";
            this.ToolBold.Click += new System.EventHandler(this.ToolBold_Click);
            // 
            // ToolItalic
            // 
            this.ToolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolItalic.Image = ((System.Drawing.Image)(resources.GetObject("ToolItalic.Image")));
            this.ToolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItalic.Name = "ToolItalic";
            this.ToolItalic.Size = new System.Drawing.Size(24, 41);
            this.ToolItalic.Text = "toolStripButton1";
            this.ToolItalic.Click += new System.EventHandler(this.ToolItalic_Click);
            // 
            // ToolUderline
            // 
            this.ToolUderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolUderline.Image = ((System.Drawing.Image)(resources.GetObject("ToolUderline.Image")));
            this.ToolUderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolUderline.Name = "ToolUderline";
            this.ToolUderline.Size = new System.Drawing.Size(24, 41);
            this.ToolUderline.Text = "toolStripButton1";
            this.ToolUderline.Click += new System.EventHandler(this.ToolUderline_Click);
            // 
            // Size
            // 
            this.Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.Size.MaxDropDownItems = 10;
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(121, 44);
            this.Size.Click += new System.EventHandler(this.Size_Click);
            this.Size.TextChanged += new System.EventHandler(this.Size_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 41);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 41);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 41);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 373);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCut,
            this.ToolCopy,
            this.ToolPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 72);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(40, 386);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ToolCut
            // 
            this.ToolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCut.Image = ((System.Drawing.Image)(resources.GetObject("ToolCut.Image")));
            this.ToolCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCut.Name = "ToolCut";
            this.ToolCut.Size = new System.Drawing.Size(37, 34);
            this.ToolCut.Text = "toolStripButton2";
            this.ToolCut.Click += new System.EventHandler(this.ToolCut_Click);
            // 
            // ToolCopy
            // 
            this.ToolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCopy.Image = ((System.Drawing.Image)(resources.GetObject("ToolCopy.Image")));
            this.ToolCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCopy.Name = "ToolCopy";
            this.ToolCopy.Size = new System.Drawing.Size(37, 33);
            this.ToolCopy.Text = "toolStripButton2";
            this.ToolCopy.Click += new System.EventHandler(this.ToolCopy_Click);
            // 
            // ToolPaste
            // 
            this.ToolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolPaste.Image = ((System.Drawing.Image)(resources.GetObject("ToolPaste.Image")));
            this.ToolPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolPaste.Name = "ToolPaste";
            this.ToolPaste.Size = new System.Drawing.Size(37, 32);
            this.ToolPaste.Text = "toolStripButton2";
            this.ToolPaste.Click += new System.EventHandler(this.ToolPaste_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 458);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Text Editor System";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem BuiltFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolNew;
        private System.Windows.Forms.ToolStripButton ToolOpen;
        private System.Windows.Forms.ToolStripButton ToolSave;
        private System.Windows.Forms.ToolStripButton ToolSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolBold;
        private System.Windows.Forms.ToolStripButton ToolItalic;
        private System.Windows.Forms.ToolStripButton ToolUderline;
        private System.Windows.Forms.ToolStripComboBox Size;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ToolCut;
        private System.Windows.Forms.ToolStripButton ToolCopy;
        private System.Windows.Forms.ToolStripButton ToolPaste;
    }
}