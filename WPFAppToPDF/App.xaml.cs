using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using WPFAppToPDF.ViewModels;
using WPFAppToPDF.Classes;

namespace WPFAppToPDF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private IServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddTransient<MainAppViewModel>();
            services.AddSingleton<FormEntry>();
            services.AddSingleton<ConvertFormToPDF>();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
           // mainWindow.DataContext = _serviceProvider.GetRequiredService<MainAppViewModel>();
            mainWindow.Show();
        }
    }
}
