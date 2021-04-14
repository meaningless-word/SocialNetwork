using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;

namespace SocialNetwork.PLL.Views
{
	public class MainView
	{
		List<string> menuItems { get; }
		public MainView()
		{
			menuItems = new List<string>()
			{
				"Войти в профиль .......................... 1",
				"Зарегистрироваться ....................... 2"
			};
		}

		public void Show()
		{
			MenuMessage.Show(menuItems);

			switch (Console.ReadLine())
			{
				case "1":
					{
						Program.authenticationView.Show();
						break;
					}
				case "2":
					{
						Program.registrationView.Show();
						break;
					}
			}
		}
	}
}
