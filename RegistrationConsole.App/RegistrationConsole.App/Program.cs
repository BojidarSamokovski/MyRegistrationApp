using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationConsole.App
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press 1 for registration or 2 for login:");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					RegisterUser();
					break;
				case "2":
					LoginUser();
					break;
				default:
					Console.WriteLine("GO F YOURSELF");
					break;
			}

			//Console.WriteLine("Username:");
			//string username = Console.ReadLine();

			//Console.WriteLine("Password:");
			//string password = Console.ReadLine();

			//if (password.Length<3)
			//{
			//	Console.WriteLine($"password must be atleast 3 chars long.");
			//}
			//else
			//{
			//	Console.WriteLine($"username:{username}");
			//	Console.WriteLine($"password:{password}");
			//}
			//Insert data in DB

		}

		private static void LoginUser()
		{
			List<string> listNames = new List<string>()
			{
				"Boiko Borisov",
				"Amazon Prime",
				"Sinyoto Momche"
			};

			Console.WriteLine(String.Join(" ", listNames));
		}

		private static void RegisterUser()
		{
			throw new NotImplementedException();
		}
	}
}
