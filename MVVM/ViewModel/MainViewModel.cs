using System.Windows.Input;
using NavTemplate.Core;
using NavTemplate.Services;

namespace NavTemplate.MVVM.ViewModel;

public class MainViewModel : Core.ViewModel
{
    public INavigationService _navigation;

    public INavigationService Navigation
    {
        get => _navigation;
        set
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }
    
    public RelayCommand NavigateHomeCommand { get; set; }
    public RelayCommand NavigateSettingsCommand { get; set; }
    
    public MainViewModel(INavigationService navService)
    {
        Navigation = navService;
        NavigateHomeCommand = new RelayCommand(o => { Navigation.NavigateTo<HomeViewModel>(); }, o => true);
        NavigateSettingsCommand = new RelayCommand(o => { Navigation.NavigateTo<SettingsViewModel>(); }, o => true);
    }
}