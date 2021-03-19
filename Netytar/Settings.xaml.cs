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
using System.Windows.Shapes;

namespace Netytar
{
    /// <summary>
    /// Logica di interazione per Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Style style = new Style { TargetType = typeof(Button) };

            style.Setters.Add(new Setter(Border.BorderBrushProperty, Brushes.Red));
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));

            Application.Current.Resources["MyButtonStyle"] = style;
        }

        private void btnPanwood_Click(object sender, RoutedEventArgs e)
        {
            rbtPanwood.IsChecked = true;
            SettingsManager.Background = Backgrounds.Panwood;
        }

        private void btnLightwood_Click(object sender, RoutedEventArgs e)
        {
            rbtLightwood.IsChecked = true;
        }

        private void btnMidwood_Click(object sender, RoutedEventArgs e)
        {
            rbtMidwood.IsChecked = true;
        }

        private void btnDarkwood_Click(object sender, RoutedEventArgs e)
        {
            rbtDarkwood.IsChecked = true;
        }
    }
 }

