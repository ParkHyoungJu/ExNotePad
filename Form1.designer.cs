namespace ExNotePad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherNameSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomTextBox1 = new System.Windows.Forms.TextBox();
            this.bottomTextBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.bottomLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.otherNameSaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            resources.ApplyResources(this.File, "File");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            resources.ApplyResources(this.newWindowToolStripMenuItem, "newWindowToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // otherNameSaveToolStripMenuItem
            // 
            this.otherNameSaveToolStripMenuItem.Name = "otherNameSaveToolStripMenuItem";
            resources.ApplyResources(this.otherNameSaveToolStripMenuItem, "otherNameSaveToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            resources.ApplyResources(this.편집EToolStripMenuItem, "편집EToolStripMenuItem");
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            resources.ApplyResources(this.서식OToolStripMenuItem, "서식OToolStripMenuItem");
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleStatusToolStripMenuItem});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            resources.ApplyResources(this.보기VToolStripMenuItem, "보기VToolStripMenuItem");
            // 
            // visibleStatusToolStripMenuItem
            // 
            this.visibleStatusToolStripMenuItem.CheckOnClick = true;
            this.visibleStatusToolStripMenuItem.Name = "visibleStatusToolStripMenuItem";
            resources.ApplyResources(this.visibleStatusToolStripMenuItem, "visibleStatusToolStripMenuItem");
            this.visibleStatusToolStripMenuItem.CheckedChanged += new System.EventHandler(this.VisibleStatusToolStripMenuItem_CheckedChanged);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메모장정ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            resources.ApplyResources(this.도움말HToolStripMenuItem, "도움말HToolStripMenuItem");
            // 
            // 메모장정ToolStripMenuItem
            // 
            this.메모장정ToolStripMenuItem.Name = "메모장정ToolStripMenuItem";
            resources.ApplyResources(this.메모장정ToolStripMenuItem, "메모장정ToolStripMenuItem");
            // 
            // bottomLayoutPanel
            // 
            this.bottomLayoutPanel.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.bottomLayoutPanel, "bottomLayoutPanel");
            this.bottomLayoutPanel.Controls.Add(this.bottomTextBox1, 2, 0);
            this.bottomLayoutPanel.Controls.Add(this.bottomTextBox2, 3, 0);
            this.bottomLayoutPanel.Controls.Add(this.textBox1, 4, 0);
            this.bottomLayoutPanel.Controls.Add(this.textBox2, 5, 0);
            this.bottomLayoutPanel.Name = "bottomLayoutPanel";
            // 
            // bottomTextBox1
            // 
            this.bottomTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.bottomTextBox1, "bottomTextBox1");
            this.bottomTextBox1.Name = "bottomTextBox1";
            // 
            // bottomTextBox2
            // 
            this.bottomTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.bottomTextBox2, "bottomTextBox2");
            this.bottomTextBox2.Name = "bottomTextBox2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.AcceptsReturn = true;
            this.bodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.bodyTextBox, "bodyTextBox");
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.TextChanged += new System.EventHandler(this.BodyTextBox_TextChanged);
            this.bodyTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bodyTextBox_MouseMove);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.bottomLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bottomLayoutPanel.ResumeLayout(false);
            this.bottomLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherNameSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visibleStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel bottomLayoutPanel;
        private System.Windows.Forms.TextBox bottomTextBox1;
        private System.Windows.Forms.TextBox bottomTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bodyTextBox;
    }
}