using System.ComponentModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IsVisibleBindingTest;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ButtonText))]
    bool isSelected = false;
    
    public string ButtonText => $"Toggle IsSelected: {IsSelected}";

    [RelayCommand]
    void ToggleIsSelected()
    {
        IsSelected = !IsSelected;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        Debug.WriteLine($"MainPageModel - {e.PropertyName}");
    }
}