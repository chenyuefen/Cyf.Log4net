using Log4net.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4netTest
{
	public partial class Log4netForm : Form
	{
		public Log4netForm()
		{
			InitializeComponent();
		}

		private void btnExportMsg_Click(object sender, EventArgs e)
		{		
			LogUtil.Instance.Debug("Debug Info");		
			LogUtil.Instance.Warn("Warn Info");
			LogUtil.Instance.Error("Eorror Info");
			LogUtil.Instance.Fatal("Fatal Info");
			LogUtil.Instance.Info("Info Info");
		}
	}
}
