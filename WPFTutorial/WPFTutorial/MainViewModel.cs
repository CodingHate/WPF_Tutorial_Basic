using CommunityToolkit.Mvvm.ComponentModel;

namespace WPFTutorial
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private decimal _value1;
        [ObservableProperty]
        private decimal _value2;
        [ObservableProperty]
        private string _operator;

        public MainViewModel()
        {
            _value1 = 123;
            _value2 = 456;
            _operator = "/";
        }

        public decimal Value1
        {
            set { _value1 = value; }
            get { return _value1; }
        }

        public decimal Value2
        {
            set { _value2 = value; }
            get { return _value2; }
        }

        public string Operator
        {
            set { _operator = value; }
            get { return _operator; }
        }
    }
}
