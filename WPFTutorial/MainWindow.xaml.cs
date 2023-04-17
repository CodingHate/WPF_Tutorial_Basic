using System.Windows;
using System.Windows.Media;
using WPFTutorial.ModelObject;

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
            MyModelObject myModelObject = new MyModelObject();
            DataContext = myModelObject;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // MainGrid
            // xaml에서 x:name으로 설정 한 변수를 가져와서 지정
            MainGrid.Background = Brushes.Green;
        }
    }
}
