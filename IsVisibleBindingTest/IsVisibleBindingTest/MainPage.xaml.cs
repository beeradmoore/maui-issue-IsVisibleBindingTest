using System.ComponentModel;

namespace IsVisibleBindingTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageModel();
    }

    void BoxView_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName}");
    }
}