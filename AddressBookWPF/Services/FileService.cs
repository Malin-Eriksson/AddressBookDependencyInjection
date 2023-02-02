using AddressBookWPF.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookWPF.Services
{
    public class FileService
    {
        private string _filePath;
        
        public FileService(string filePath)
        {
            _filePath = filePath;
        }


       public string ReadFromFile()
        {
            if(File.Exists(_filePath)) 
            {
                using var sr = new StreamReader(_filePath);
                return sr.ReadToEnd();
            }

            return string.Empty;
            
        }
            
        public void SaveFile(string contentAddressBook)
        {
            using var sw = new StreamWriter(_filePath);
            sw.Write(contentAddressBook);
        }






        private List<ContactModel> contacts;


        /*        public FileService()
                {
                    ReadFromFile();
                }

                private void ReadFromFile()
                {
                    try
                    {
                        using var sr = new StreamReader(_filePath);
                        contacts = JsonConvert.DeserializeObject<List<ContactModel>>(sr.ReadToEnd())!;
                    }
                    catch { contacts = new List<ContactModel>(); }
                }*/


/*        private void SaveToFile()
        {
            using var sw = new StreamWriter(_filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));
        }*/

        public void AddToList(ContactModel contact)
        {
            contacts.Add(contact);
            SaveFile(_filePath);
        }

        public ObservableCollection<ContactModel> Contacts()
        {
            var items = new ObservableCollection<ContactModel>();
            foreach (var contact in contacts)
                items.Add(contact);

            return items;
        }

    }
}

