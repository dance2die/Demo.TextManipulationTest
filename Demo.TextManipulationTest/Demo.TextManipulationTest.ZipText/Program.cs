using System;

namespace Demo.TextManipulationTest.ZipText
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var text = "This is a tweet to zip!";
			byte[] zipped = TextZip.Zip(text);
			DumpZipped(zipped);

			var unzippedText = TextZip.Unzip(zipped);
			Console.WriteLine("UnZipped: {0}", unzippedText);
		}

		private static void DumpZipped(byte[] zipped)
		{
			Console.WriteLine(string.Join(", ", zipped));
		}
	}
}
