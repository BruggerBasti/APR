namespace WeatherApp;

using WeatherApp.ViewModels;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainViewModel();
	}
}


