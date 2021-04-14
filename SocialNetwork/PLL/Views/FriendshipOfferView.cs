using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
	public class FriendshipOfferView
	{
		UserService userService;

		public FriendshipOfferView(UserService userService)
		{
			this.userService = userService;
		}
		public void Show(User user)
		{
			var friendshipOffer = new FriendshipOffer();

			Console.WriteLine("Введите почтовый адрес пользователя которого хотите добавить в друзья: ");
			friendshipOffer.FriendEmail = Console.ReadLine();
			friendshipOffer.HostId = user.Id;

			try
			{
				userService.BeMyFriend(friendshipOffer);
				SuccessMessage.Show("Друг добавлен в список!");
			}
			catch (UserNotFoundException)
			{
				AlertMessage.Show("Пользователь не найден!");
			}
			catch (ArgumentNullException)
			{
				AlertMessage.Show("Введите корректное значение!");
			}
			catch (Exception)
			{
				AlertMessage.Show("Произошла ошибка при добавлении в друзья!");
			}
		}
	}
}
