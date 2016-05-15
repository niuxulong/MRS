using MRS.Views.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            DataCacheManager.DataCacheManager.GetCacheManagerInstance().InitilizeDataCache();
			Application.Run(new ElecCaseHistoryView());
            
		}
	}
}
