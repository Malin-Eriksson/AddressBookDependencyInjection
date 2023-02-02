using AddressBookWPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace AddressBookWPF.MVVM.ViewModels


{
    internal class MainViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrrentViewModelChanged += OnCurrentViewModelChanged;
        }

        public ObservableObject CurrentViewModel => _navigationStore.CurrentViewModel;

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }


    /*    public partial class MainViewModel : ObservableObject
        {
            [ObservableProperty]
            private ObservableObject currentViewModel = new ContactsViewModel();


            //Navigation

            [RelayCommand]
            private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();


            [RelayCommand]
            private void GoToContacts() => CurrentViewModel = new ContactsViewModel();




            public MainViewModel()
            {
                CurrentViewModel = new ContactsViewModel();
            }
        }*/
}
