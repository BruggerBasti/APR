using System;
using ModoloRechner.ViewModels;

namespace ModoloRechner;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new MainViewModel();
    }
}


