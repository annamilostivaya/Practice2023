using coffe.DbContexts;
using coffe.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using coffe.ViewModel;
using coffe.NavigationServises;
using System.Runtime.InteropServices.JavaScript;

namespace coffe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IHost host;

        public App()
        {
            host = Host.CreateDefaultBuilder().ConfigureServices((Services) =>
            {
                Services.AddViewsModels();
                Services.AddDbContext<UserDbContext>((Options) =>
                {
                    Options.UseSqlite("Data source = coffe.db");
                });




                Services.AddSingleton(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainViewModel>()
                });





            }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
        
            host.Start();
      
            NavigationService<AuthorizationVM> navigationService = host.Services.GetRequiredService<NavigationService<AuthorizationVM>>();
           /* navigationService.Navigate();*/


            MainWindow = host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            navigationService.Navigate(); 
            base.OnStartup(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            host.Dispose();
        }

    }
    
}