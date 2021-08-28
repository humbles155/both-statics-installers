using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace Static_Installer
{
	internal class Program
	{
		private static async Task Main(string[] args)
		{
			string link1 = "https://raw.githubusercontent.com/Anon698/file-installer/main/README.md";
			string exploitname = "Static";
			Console.Title = "Static";
			Console.WriteLine("Loading Installer.");
			await Task.Delay(500);
			Console.WriteLine("Installing Files. (Please Wait)");
			await Task.Delay(500);
			WebClient wb = new WebClient();
			WebClient dow = new WebClient();
			string noob = wb.DownloadString(link1);
			dow.DownloadFile(noob, exploitname + ".zip");
			wb.Dispose();
			dow.Dispose();
			await Task.Delay(2500);
			Console.WriteLine("Downloading Files Into Current Directory.");
			await Task.Delay(500);
			ZipFile.ExtractToDirectory(Environment.CurrentDirectory + "/" + exploitname + ".zip", Environment.CurrentDirectory);
			File.Delete(exploitname + ".zip");
			Console.WriteLine("Exploit Downloaded!");
			await Task.Delay(2000);
		}
	}
}
