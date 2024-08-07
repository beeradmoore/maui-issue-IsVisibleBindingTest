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
        if (sender is BoxView boxView)
        {
            if (e.PropertyName == BoxView.XProperty.PropertyName)
            {
                Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName} - {boxView.X}");
            }
            else if (e.PropertyName == BoxView.YProperty.PropertyName)
            {
                Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName} - {boxView.Y}");
            }
            else if (e.PropertyName == BoxView.WidthProperty.PropertyName)
            {
                Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName} - {boxView.Width}");
            }
            else if (e.PropertyName == BoxView.HeightProperty.PropertyName)
            {
                Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName} - {boxView.Height}");
            }
            else
            {
                Console.WriteLine($"BoxView_OnPropertyChanged - {e.PropertyName}");
            }

        }
    }
}