using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassRoomApp.ViewModel.Base
{
    public class BaseViewModel : ObservableObject
    {
        public IAsyncRelayCommand ExecuteCommand { get; set; }
        public IAsyncRelayCommand RedirectCommand { get; set; }
    }
}
