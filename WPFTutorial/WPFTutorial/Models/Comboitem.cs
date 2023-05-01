using System.Collections.Generic;
using System.Windows.Media;

namespace WPFTutorial.Models
{
    class Comboitem
    {
        public Comboitem()
        {

        }

        public string Value { get; set; } = "";
        public Brush Brush { get; set; } = default;

        public override string ToString()
        {
            return $"Value: {Value} / Brush: {Brush}";
        }

        public static List<Comboitem> Items => new List<Comboitem>
        {
            new Comboitem{Value="빨간색", Brush = Brushes.Red},
            new Comboitem{Value="파란색", Brush = Brushes.Blue},
            new Comboitem{Value="노란색", Brush = Brushes.Yellow},
        };
    }
}
