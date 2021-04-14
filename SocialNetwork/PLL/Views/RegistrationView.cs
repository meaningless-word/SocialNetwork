using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
	public class RegistrationView
	{
		UserService userService;
		public RegistrationView(UserService userService)
		{
			this.userService = userService;
		}

		public void Show()
		{
			var userRegistrationData = new UserRegistrationData();

			Console.WriteLine("Для создания нового профиля введите ваше имя: ");
			userRegistrationData.FirstName = Console.ReadLine();
			Console.WriteLine("Ваша фамилия: ");
			userRegistrationData.LastName = Console.ReadLine();
			Console.WriteLine("Пароль: ");
			userRegistrationData.Password = Console.ReadLine();
			Console.WriteLine("Почтовый адрес: ");
			userRegistrationData.Email = Console.ReadLine();

			try
			{
				userService.Register(userRegistrationData);

				SuccessMessage.Show("Ваш профиль создан. Теперь Вы сожете войти в систему под своими учетными данными.");
			}
			catch (ArgumentNullException)
			{
				Console.WriteLine("Введите корректное значение.");
			}
			catch (Exception)
			{
				Console.WriteLine("Произошла ошибка регистрации.");
			}
		}
	}
}
