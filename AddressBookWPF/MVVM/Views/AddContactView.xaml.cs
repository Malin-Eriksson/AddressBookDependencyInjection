using AddressBookWPF.MVVM.Models;
using AddressBookWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddressBookWPF.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddContactView.xaml
    /// </summary>
    public partial class AddContactView : UserControl
    {
        public AddContactView()
        {
            InitializeComponent();

        }

        /*        private void btn_add_Click(object sender, RoutedEventArgs e)
                {
                    var button = (Button)sender;
                    var contact = (ContactModel)button.DataContext;


                    ContactService.Add(contact);

                }*/


    }
}
