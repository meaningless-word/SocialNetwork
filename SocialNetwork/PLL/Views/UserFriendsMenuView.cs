using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Views
{
	public class UserFriendsMenuView
	{
		UserService userService;

		List<string> menuItems { get; }

		public UserFriendsMenuView(UserService userService)
		{
			this.userService = userService;

			menuItems = new List<string>()
			{
				"Список друзей ............................ 1",
				"Добавить в друзья ........................ 2",
				"Исключить из друзей ...................... 3",
				"Вернуться в профиль ...................... 4"
			};
		}

		public void Show(User user)
		{
			while (true)
			{
				Console.WriteLine("Всего друзей: {0}", user.Friends.Count());

				MenuMessage.Show(menuItems);

				string keyValue = Console.ReadLine();
				if (keyValue == "4") break;

				switch (keyValue)
				{
					case "1":
						{
							Program.userFriendView.Show(user.Friends);
							break;
						}
					case "2":
						{
							Program.friendshipOfferView.Show(user);
							user = userService.FindById(user.Id);
							break;
						}
					case "3":
						{
							Program.friendshipBreakView.Show(user);
							user = userService.FindById(user.Id);
							break;
						}
				}
			}
		}
	}
}
