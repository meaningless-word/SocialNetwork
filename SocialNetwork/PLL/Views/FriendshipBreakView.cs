using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
	public class FriendshipBreakView
	{
		UserService userService;

		public FriendshipBreakView(UserService userService)
		{
			this.userService = userService;
		}
		public void Show(User user)
		{
			var friendshipOffer = new FriendshipOffer();

			Console.WriteLine("Введите почтовый адрес пользователя которого хотите исключить из друзей: ");
			friendshipOffer.FriendEmail = Console.ReadLine();
			friendshipOffer.HostId = user.Id;

			try
			{
				userService.DontBeMyFriend(friendshipOffer);
				SuccessMessage.Show("Друг исключен из списка!");
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
				AlertMessage.Show("Произошла ошибка при исключении из друзей!");
			}
		}
	}
}
