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
			string title = "\r\n\r\n░██████╗████████╗░█████╗░████████╗██╗░█████╗░\r\n██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██║██╔══██╗\r\n╚█████╗░░░░██║░░░███████║░░░██║░░░██║██║░░╚═╝\r\n░╚═══██╗░░░██║░░░██╔══██║░░░██║░░░██║██║░░██╗\r\n██████╔╝░░░██║░░░██║░░██║░░░██║░░░██║╚█████╔╝\r\n╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░               \r\n";
			string link1 = "https://raw.githubusercontent.com/Anon698/Static-Loader/main/README.md";
			string exploitname = "Static";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Title = "Static";
			Console.WriteLine(title);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("[INFO]: Welcome to " + exploitname);
			Console.WriteLine("[INFO]: https://discord.gg/VvK7VFBecU");
			await Task.Delay(5000);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("[DOWNLOAD]: Download Starting");
			WebClient wb = new WebClient();
			WebClient dow = new WebClient();
			string noob = wb.DownloadString(link1);
			dow.DownloadFile(noob, exploitname + ".zip");
			wb.Dispose();
			dow.Dispose();
			await Task.Delay(5000);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("[DOWNLOAD]: Exploit downloaded succesfully");
			Console.WriteLine("[EXTRACTION]: Extracting zip");
			ZipFile.ExtractToDirectory(Environment.CurrentDirectory + "/" + exploitname + ".zip", Environment.CurrentDirectory);
			File.Delete(exploitname + ".zip");
			await Task.Delay(5000);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("[EXTRACTION]: Extracted Succesfully");
			await Task.Delay(5000);
			Console.WriteLine("[SUCCESS] Thanks for downloading");
			Console.WriteLine("Closing in 5 seconds");
			await Task.Delay(5000);
		}
	}
}
