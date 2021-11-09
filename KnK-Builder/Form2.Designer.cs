namespace KnK_Builder
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00004048 File Offset: 0x00002248
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004068 File Offset: 0x00002268
		private void InitializeComponent()
		{
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.startproxy = new MetroFramework.Controls.MetroButton();
            this.stopproxy = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(6, 15);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "MAC here...";
            this.metroTextBox1.Size = new System.Drawing.Size(363, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 53;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // startproxy
            // 
            this.startproxy.Highlight = true;
            this.startproxy.Location = new System.Drawing.Point(7, 76);
            this.startproxy.Margin = new System.Windows.Forms.Padding(2);
            this.startproxy.Name = "startproxy";
            this.startproxy.Size = new System.Drawing.Size(181, 95);
            this.startproxy.Style = MetroFramework.MetroColorStyle.Red;
            this.startproxy.TabIndex = 58;
            this.startproxy.Text = "Start Proxy";
            this.startproxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startproxy.Click += new System.EventHandler(this.Startproxy_Click);
            // 
            // stopproxy
            // 
            this.stopproxy.Enabled = false;
            this.stopproxy.Highlight = true;
            this.stopproxy.Location = new System.Drawing.Point(201, 76);
            this.stopproxy.Margin = new System.Windows.Forms.Padding(2);
            this.stopproxy.Name = "stopproxy";
            this.stopproxy.Size = new System.Drawing.Size(181, 95);
            this.stopproxy.Style = MetroFramework.MetroColorStyle.Red;
            this.stopproxy.TabIndex = 55;
            this.stopproxy.Text = "Stop Proxy";
            this.stopproxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stopproxy.Click += new System.EventHandler(this.Stopproxy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 24);
            this.panel1.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 22);
            this.button2.TabIndex = 50;
            this.button2.Text = "Builder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(7, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 46);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAC";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(390, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopproxy);
            this.Controls.Add(this.startproxy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Proxy";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001F RID: 31
		private global::MetroFramework.Controls.MetroTextBox metroTextBox1;

		// Token: 0x04000020 RID: 32
		private global::MetroFramework.Controls.MetroButton startproxy;

		// Token: 0x04000021 RID: 33
		private global::MetroFramework.Controls.MetroButton stopproxy;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
