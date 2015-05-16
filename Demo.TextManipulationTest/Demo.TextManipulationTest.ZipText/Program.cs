using System;
using System.IO;

namespace Demo.TextManipulationTest.ZipText
{
	public class Program
	{
		private const string zippedFile = @"c:\temp\zippedFile.txt";
		private const string unzippedFile = @"c:\temp\unzippedFile.txt";

		public static void Main(string[] args)
		{
			var text = "This is a tweet to zip!";
			byte[] zipped = TextZip.Zip(text);
			DumpZipped(zipped);
			Writezipped(zipped);

			var unzippedText = TextZip.Unzip(zipped);
			Console.WriteLine("UnZipped: {0}", unzippedText);
			WriteText(unzippedText);
		}

		private static void WriteText(string unzippedText)
		{
			File.WriteAllText(unzippedFile, unzippedText);
		}

		private static void Writezipped(byte[] zipped)
		{
			using (var fs = new FileStream(zippedFile, FileMode.OpenOrCreate, FileAccess.Write))
			{
				fs.Write(zipped, 0, zipped.Length);
			}
		}

		private static void DumpZipped(byte[] zipped)
		{
			Console.WriteLine(string.Join(", ", zipped));
		}
	}
}
