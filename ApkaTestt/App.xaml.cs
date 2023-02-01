using ApkaTest.Database;
using ApkaTest.Domain.Interfaces;
using ApkaTest.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApkaTestt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IDataStoreManager, DataStoreManager>();
            serviceCollection.AddTransient<ICalculatorManager, CalculatorManager>();

        }
    }
}
