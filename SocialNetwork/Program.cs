using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork
{
	class Program
	{
		static MessageService messageService;
		static UserService userService;

		public static MainView mainView;
		public static RegistrationView registrationView;
		public static AuthenticationView authenticationView;
		public static UserMenuView userMenuView;
		public static UserInfoView userInfoView;
		public static UserDataUpdateView userDataUpdateView;
		public static MessageSendingView messageSendingView;
		public static UserIncomingMessageView userIncomingMessageView;
		public static UserOutgoingMessageView userOutgoingMessageView;
		public static FriendshipOfferView friendshipOfferView;
		public static FriendshipBreakView friendshipBreakView;
		public static UserFriendsMenuView userFriendsMenuView;
		public static UserFriendView userFriendView;

		static void Main(string[] args)
		{
			userService = new UserService();
			messageService = new MessageService();

			mainView = new MainView();
			registrationView = new RegistrationView(userService);
			authenticationView = new AuthenticationView(userService);
			userMenuView = new UserMenuView(userService);
			userInfoView = new UserInfoView();
			userDataUpdateView = new UserDataUpdateView(userService);
			messageSendingView = new MessageSendingView(messageService, userService);
			userIncomingMessageView = new UserIncomingMessageView();
			userOutgoingMessageView = new UserOutgoingMessageView();
			friendshipOfferView = new FriendshipOfferView(userService);
			friendshipBreakView = new FriendshipBreakView(userService);
			userFriendsMenuView = new UserFriendsMenuView(userService);
			userFriendView = new UserFriendView();

			while (true)
			{
				mainView.Show();
			}
		}
	}
}
