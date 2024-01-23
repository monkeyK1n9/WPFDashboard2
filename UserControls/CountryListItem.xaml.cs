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

namespace WPFDashboard2.UserControls
{
    /// <summary>
    /// Interaction logic for CountryListItem.xaml
    /// </summary>
    public partial class CountryListItem : UserControl
    {
        public static readonly DependencyProperty CountryNameProperty = DependencyProperty.Register(
            "CountryName",
            typeof(string),
            typeof(CountryListItem)
        );

        public static readonly DependencyProperty PriceProperty = DependencyProperty.Register(
            "Price",
            typeof(string),
            typeof(CountryListItem)
        );

        public static readonly DependencyProperty IsLevelUpProperty = DependencyProperty.Register(
            "IsLevelUp",
            typeof(bool),
            typeof(CountryListItem)
        );

        public static readonly DependencyProperty FlagProperty = DependencyProperty.Register(
            "Flag",
            typeof(ImageSource),
            typeof(CountryListItem)
        );

        public string CountryName
        {
            get => (string)GetValue(CountryNameProperty);
            set => SetValue(CountryNameProperty, value);
        }

        public string Price
        {
            get => (string)GetValue(PriceProperty);
            set => SetValue(PriceProperty, value);
        }

        public bool IsLevelUp
        {
            get => (bool)GetValue(IsLevelUpProperty);
            set => SetValue(IsLevelUpProperty, value);
        }

        public ImageSource Flag
        {
            get => (ImageSource)GetValue(FlagProperty);
            set => SetValue(FlagProperty, value);
        }

        public CountryListItem()
        {
            InitializeComponent();
        }
    }
}
