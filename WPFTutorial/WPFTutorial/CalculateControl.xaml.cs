using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// CalculateControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CalculateControl : UserControl
    {
        public CalculateControl()
        {
            InitializeComponent();
        }



        public int Value1
        {
            get { return (int)GetValue(Value1Property); }
            set { SetValue(Value1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Value1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Value1Property =
            DependencyProperty.Register("Value1", typeof(int), typeof(CalculateControl), new PropertyMetadata(0));


    }
}
