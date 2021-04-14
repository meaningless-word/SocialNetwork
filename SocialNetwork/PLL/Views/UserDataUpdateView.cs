using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
	public class UserDataUpdateView
	{
		UserService userService;
		public UserDataUpdateView(UserService userService)
		{
			this.userService = userService;
		}

		public void Show(User user)
		{
			Console.WriteLine("Меня зовут: ");
			user.FirstName = Console.ReadLine();
			Console.WriteLine("Моя фамилия: ");
			user.LastName = Console.ReadLine();
			Console.WriteLine("Ссылка на моё фото: ");
			user.Photo = Console.ReadLine();
			Console.WriteLine("Мой любиымй фильм: ");
			user.FavoriteMovie = Console.ReadLine();
			Console.WriteLine("Моя любимая книга: ");
			user.FavoriteBook = Console.ReadLine();

			this.userService.Update(user);

			SuccessMessage.Show("Ваш профиль успешно обновлен!");
		}
	}
}
