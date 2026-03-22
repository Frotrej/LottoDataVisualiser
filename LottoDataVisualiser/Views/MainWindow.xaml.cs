using LottoApp.ViewModels;
using System.Windows;

namespace LottoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
		}

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            NewestDrawsViewModel GamesDraws = new NewestDrawsViewModel();
            await GamesDraws.Initialize();
			DataContext = GamesDraws;
		}
	}
}