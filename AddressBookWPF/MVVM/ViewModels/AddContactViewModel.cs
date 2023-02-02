using AddressBookWPF.Helpers;
using AddressBookWPF.MVVM.Models;
using AddressBookWPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AddressBookWPF.MVVM.ViewModels
{

    internal class AddContactViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ContactService _contactService;

        public ICommand AddCommand { get; }
        public ICommand CancelCommand { get; }

        public ContactModel Contact { get; set; } = new ContactModel();

        public AddContactViewModel(NavigationStore navigationStore, ContactService contactService)
        {
            _navigationStore = navigationStore;
            _contactService = contactService;

            AddCommand = AddContact();
            CancelCommand = Cancel();

        }

        private ICommand AddContact()
        {
            _contactService.AddToList(Contact);
            return new NavigateCommand<AddContactViewModel>(_navigationStore, () => new AddContactViewModel(_navigationStore, _contactService));
        }

        private ICommand Cancel()
        {
            Contact = new ContactModel();
            return new NavigateCommand<ContactsViewModel>(_navigationStore, () => new ContactsViewModel(_navigationStore, _contactService));
        }


 



    }



    /* public partial class AddContactViewModel : ObservableObject
     {
 *//*       gammalt
  *       private readonly FileService fileService;

         public AddContactViewModel()
         {
             fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contentAddressBook.json");
             contacts = fileService.Contacts();
         }*//*


         [ObservableProperty]
         private string pageTitle = "Add Contact";

         [ObservableProperty]
         private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

         [ObservableProperty]
         private string contact = string.Empty;

         [ObservableProperty]
         private ContactModel contactModel = new ContactModel();


         [RelayCommand]
         public void Add()
         {
             ContactService.Add(contactModel);
             contactModel = new ContactModel();
         }
     }*/
}
