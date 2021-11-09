using System;
using System.Windows.Forms;

namespace KnK_Builder
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00004529 File Offset: 0x00002729
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
