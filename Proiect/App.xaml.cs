using Proiect.Models;

namespace Proiect;

public partial class App : Application
{

	public static UserInfo UserInfo;
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
