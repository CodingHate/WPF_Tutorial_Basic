using System.Windows;
using WPFTutorial.ViewModels;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RedViewModel();
        }

        private void BlueView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BlueViewModel();
        }

        private void Default_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
