using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Views
{
	public class UserMenuView
	{
		UserService userService;
		List<string> menuItems { get; }
		public UserMenuView(UserService userService)
		{
			this.userService = userService;
			menuItems = new List<string>()
			{
				"Посмотреть информацию о моём профиле ..... 1",
				"Редактировать мой профиль ................ 2",
				"Друзья ................................... 3",
				"Написать сообщение ....................... 4",
				"Просмотреть входящие сообщения ........... 5",
				"Просмотреть исходящие сообщения .......... 6",
				"Выйти из профиля ......................... 7"
			};
		}

		public void Show(User user)
		{
			while (true)
			{
				Console.WriteLine("Входящие сообщения: {0}", user.IncomingMessages.Count());
				Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());

				MenuMessage.Show(menuItems);

				string keyValue = Console.ReadLine();
				if (keyValue == "7") break;

				switch (keyValue)
				{
					case "1":
						{
							Program.userInfoView.Show(user);
							break;
						}
					case "2":
						{
							Program.userDataUpdateView.Show(user);
							user = userService.FindById(user.Id);
							break;
						}
					case "3":
						{
							Program.userFriendsMenuView.Show(user);
							break;
						}
					case "4":
						{
							Program.messageSendingView.Show(user);
							user = userService.FindById(user.Id);
							break;
						}
					case "5":
						{
							Program.userIncomingMessageView.Show(user.IncomingMessages);
							break;
						}
					case "6":
						{
							Program.userOutgoingMessageView.Show(user.OutgoingMessages);
							break;
						}
				}
			}
		}
	}
}
