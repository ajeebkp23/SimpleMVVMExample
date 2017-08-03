using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace SimpleMVVMExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();
            ProductViewModel context = new ProductViewModel();
            ProductModel pm = new ProductModel { ProductName = "FirstProduct", ProductId = 1, UnitPrice = 13 };
            app.DataContext = pm;
            app.Show();
        }

    }
}
