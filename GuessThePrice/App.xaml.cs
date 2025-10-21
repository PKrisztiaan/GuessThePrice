using System.Configuration;
using System.Data;
using System.Windows;
using GuessThePrice.Model;
using GuessThePrice.ViewModel;

namespace GuessThePrice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _window;
        private GuessThePriceViewModel _viewModel;
        private GuessThePriceModel _model;
        public App()
        {
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            _window = new MainWindow();
            _model = new GuessThePriceModel();
            _viewModel = new GuessThePriceViewModel(_model);
            _window.DataContext = _viewModel;
            _window.Show();
        }
    }

}
