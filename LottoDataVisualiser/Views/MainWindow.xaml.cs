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
            var tabsSource= new GameTabs();
            await tabsSource.Initialize();
			DataContext = tabsSource;
		}
	}
}