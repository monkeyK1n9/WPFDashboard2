using MahApps.Metro.IconPacks;
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
    /// Interaction logic for InfoCard.xaml
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(string),
            typeof(InfoCard)
        );
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register(
            "Number",
            typeof(string),
            typeof(InfoCard)
        );
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive",
            typeof(bool),
            typeof(InfoCard)
        );
        public static readonly DependencyProperty IsTechnicalProperty = DependencyProperty.Register(
            "IsTechnical",
            typeof(bool),
            typeof(InfoCard)
        );

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public string Number
        {
            get => (string)GetValue(NumberProperty);
            set => SetValue(NumberProperty, value);
        }
        public bool IsActive
        {
            get => (bool)GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);
        }
        public bool IsTechnical
        {
            get => (bool)GetValue(IsTechnicalProperty);
            set => SetValue(IsTechnicalProperty, value);
        }
        public InfoCard()
        {
            InitializeComponent();
        }
    }
}
