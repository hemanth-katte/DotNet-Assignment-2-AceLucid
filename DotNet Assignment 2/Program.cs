using System.Text.RegularExpressions;

namespace DotNet_Assignment_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			Console.WriteLine("Enter your string : ");
			string str = Console.ReadLine();
			string date = DateExtractor(str);
			if(date == null)
			{
				Console.WriteLine("No date found of the given format");
				Console.ReadKey();
				return;
			}
			Console.WriteLine("Valid date found : " + date);

			Console.ReadKey();

		}

		static string DateExtractor(string date)
		{
			string pattern = @"(0[1-9]|1[0-2])(0[1-9]|1\d|2[0-9]|3[01])(\d{4})";
			Regex regex = new Regex(pattern);

			string validDate = null;
			Match match = regex.Match(date);

			if (match.Success)
			{
				return match.Value;
			}
			return validDate;

		}
	}
}