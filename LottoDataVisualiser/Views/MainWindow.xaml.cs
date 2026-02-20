using System.Windows;

namespace LottoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ViewModels.LottoViewModel();

		}

	}
}