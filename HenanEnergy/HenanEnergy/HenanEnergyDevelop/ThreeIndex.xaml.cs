using LiveCharts;
using LiveCharts.Defaults;
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

namespace HenanEnergy.HenanEnergyDevelop
{
    /// <summary>
    /// ThreeIndex.xaml 的交互逻辑
    /// </summary>
    public partial class ThreeIndex : UserControl
    {
        public ThreeIndex()
        {
            InitializeComponent();
            Values1 = new ChartValues<ObservableValue>
            {
                new ObservableValue(3),
                new ObservableValue(4),
                new ObservableValue(6),
                new ObservableValue(3),
                new ObservableValue(2),
                new ObservableValue(6)
            };
            Values2 = new ChartValues<ObservableValue>
            {
                new ObservableValue(5),
                new ObservableValue(3),
                new ObservableValue(5),
                new ObservableValue(7),
                new ObservableValue(3),
                new ObservableValue(9)
            };
            Values3 = new ChartValues<ObservableValue>
            {
                new ObservableValue(7),
                new ObservableValue(5),
                new ObservableValue(3),
                new ObservableValue(5),
                new ObservableValue(3),
                new ObservableValue(9)
            };

            DataContext = this;
        }

        public ChartValues<ObservableValue> Values1 { get; set; }
        public ChartValues<ObservableValue> Values2 { get; set; }
        public ChartValues<ObservableValue> Values3 { get; set; }
    }
}
