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
            LottoViewModel lotto = new ViewModels.LottoViewModel();
            await lotto.Initialize();
			DataContext = lotto;
		}
	}
}