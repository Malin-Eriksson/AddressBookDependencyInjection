using AddressBookWPF.MVVM.ViewModels;
using AddressBookWPF.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AddressBookWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static IHost app {  get; private set; }

        public App()
        {
            app = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<NavigationStore>();
                services.AddSingleton<ContactService>();

            }).Build();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            var contactService = app!.Services.GetRequiredService<ContactService>();
            var navigationStore = app!.Services.GetRequiredService<NavigationStore>();
            navigationStore.CurrentViewModel = new ContactsViewModel(navigationStore, contactService);

            app.Start();

            var MainWindow = app.Services.GetRequiredService<MainWindow>();
            MainWindow.DataContext = new MainViewModel(navigationStore);
            MainWindow.Show();
            base.OnStartup(e);
        }



        /*        protected override void OnStartup(StartupEventArgs e)
                {
                    MainWindow = new MainWindow()
                    {
                        DataContext = new MainViewModel()
                    };

                    MainWindow.Show();
                    base.OnStartup(e);
                }*/
    }
}
