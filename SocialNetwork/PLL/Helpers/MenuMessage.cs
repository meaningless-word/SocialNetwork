using System;
using System.Collections.Generic;

namespace SocialNetwork.PLL.Helpers
{
	public class MenuMessage
	{
		public static void Show(List<string> menuItems)
		{
			ConsoleColor originalColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Cyan;
			menuItems.ForEach(m =>
			{
				Console.WriteLine(m);
			});
			Console.ForegroundColor = originalColor;
		}
	}
}
