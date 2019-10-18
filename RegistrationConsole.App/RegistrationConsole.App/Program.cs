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
			List<string> listNames	= new List<string>()
			{
				"Boiko Borisov",
				"Amazon Prime",
				"Sinyoto Momche"
			};

			Console.WriteLine( String.Join(" ", listNames ) );
		}
	}
}
