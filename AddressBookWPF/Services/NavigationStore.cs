using AddressBookWPF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookWPF.Services
{
    internal class NavigationStore
    {
        public event Action? CurrrentViewModelChanged;

        private ObservableObject? _currentViewModel;
        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel!;
            set
            {
                _currentViewModel = value;
                OnCurrenViewModelChanged();
            }
        }

        private void OnCurrenViewModelChanged()
        {
            CurrrentViewModelChanged?.Invoke();
        }
    }
}
