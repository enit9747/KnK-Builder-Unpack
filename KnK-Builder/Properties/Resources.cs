using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace KnK_Builder.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00004540 File Offset: 0x00002740
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00004548 File Offset: 0x00002748
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("KnK_Builder.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004574 File Offset: 0x00002774
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000457B File Offset: 0x0000277B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004583 File Offset: 0x00002783
		internal static byte[] probably
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("probably", Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000459E File Offset: 0x0000279E
		internal static string Stub
		{
			get
			{
				return Resources.ResourceManager.GetString("Stub", Resources.resourceCulture);
			}
		}

		// Token: 0x04000025 RID: 37
		private static ResourceManager resourceMan;

		// Token: 0x04000026 RID: 38
		private static CultureInfo resourceCulture;
	}
}
