using LiveCharts;
using LiveCharts.Wpf;
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
    /// EconomyEnergyRelationship.xaml 的交互逻辑
    /// </summary>
    public partial class EconomyEnergyRelationship : UserControl
    {
        public EconomyEnergyRelationship()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "地区生产总值增速",
                    Values = new ChartValues<double> { 0.10, 0.50, 0.39, 0.50 , 0.78, 0.35, 0.26, 0.11 }
                    
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "能源消费增速",
                Values = new ChartValues<double> { 0.11, 0.56, 0.42, 0.78, 0.35, 0.26, 0.11, 0.65 }
               
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "规上企业用电增速",
                Values = new ChartValues<double> { 0.56, 0.42, 0.78, 0.35, 0.11, 0.56, 0.42, 0.50 }
              
            });

            //also adding values updates and animates the chart automatically
            //SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "2011", "2012", "2013", "2014","2015", "2016", "2017", "2018" };
            //Formatter = value => value.ToString("N");

            Formatter = value => value.ToString("P");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
