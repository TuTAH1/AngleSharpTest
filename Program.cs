using AngleSharp.Io;
using AngleSharp;
using UpdaterForm.Forms;

namespace UpdaterForm
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static async Task Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			var form = new Form1();

			var urlAddress = "https://github.com/TuTAH1/xml-js-Parser/releases";

			var requester = new DefaultHttpRequester("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:99.0) Gecko/20100101 Firefox/99.0");
			var config = new Configuration().WithDefaultLoader().With(requester);
			var document = await BrowsingContext.New(config).OpenAsync(urlAddress);

			MessageBox.Show("all ok");
		}
	}
}