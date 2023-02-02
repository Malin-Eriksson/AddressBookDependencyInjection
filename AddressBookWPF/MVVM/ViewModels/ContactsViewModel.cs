using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using AddressBookWPF.MVVM.Models;
using AddressBookWPF.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;
using System.Windows.Input;
using AddressBookWPF.Helpers;

namespace AddressBookWPF.MVVM.ViewModels
{
    internal class ContactsViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ContactService _contactService;

        public ICommand NavigateToAddCommand { get; }

        public ContactsViewModel(NavigationStore navigationStore, ContactService contactService)
        {
            _navigationStore = navigationStore;
            _contactService = contactService;
            NavigateToAddCommand = new NavigateCommand<AddContactViewModel>(navigationStore, () => new AddContactViewModel(_navigationStore, _contactService));

        }

/*
        private ContactModel selectedContact = null!;


        public ICommand Remove()
        {

            string mb_message = "Are you sure you want to delete this contact?";
            string mb_title = "Delete contact";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxImage mb_icon = MessageBoxImage.Question;
            MessageBoxResult result;


            result = MessageBox.Show(mb_message, mb_title, buttons, mb_icon, MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes)
            {
                ContactService.Remove(SelectedContact);
            }
            else { }

        }
*/



    }



    /* public partial class ContactsViewModel : ObservableObject
     {
         *//*  
          *  gammalt
          *  private readonly FileService fileService;
                 public ContactsViewModel()
                 {
                     fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contentAddressBook.json");
                     contacts = fileService.Contacts();
                 }*//*



         [ObservableProperty]
         private string pageTitle = "Contacts";

         [ObservableProperty]
         private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

         [ObservableProperty]
         private ContactModel selectedContact = null!;


         [RelayCommand]
         public void Remove()
         {
             string mb_message = "Are you sure you want to delete this contact?";
             string mb_title = "Delete contact";
             MessageBoxButton buttons = MessageBoxButton.YesNo;
             MessageBoxImage mb_icon = MessageBoxImage.Question;
             MessageBoxResult result;


             result = MessageBox.Show(mb_message, mb_title, buttons, mb_icon, MessageBoxResult.Yes);

             if (result == MessageBoxResult.Yes) 
             {
                 ContactService.Remove(SelectedContact);
             }
             else { }

         }



     }*/
}
