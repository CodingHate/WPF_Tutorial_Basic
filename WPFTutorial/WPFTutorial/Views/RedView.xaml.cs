using System.Windows;
using System.Windows.Controls;

namespace WPFTutorial.Views
{
    /// <summary>
    /// RedView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RedView : UserControl
    {
        public RedView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click");
        }
    }
}
