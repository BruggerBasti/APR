using System;
using ZahlGenerieren.ViewModels;

namespace ZahlGenerieren;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainViewModel();
	}
}


