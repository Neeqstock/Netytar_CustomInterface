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

        private void Btn_Secondo_Click(object sender, RoutedEventArgs e)
        {
            if (line.StrokeThickness < 17) 
                {
                    line.StrokeThickness += 1;
                }
        }

        private void Btn_Primo_Click(object sender, RoutedEventArgs e)
        {
            if (line.StrokeThickness >= 3)
            {
                line.StrokeThickness -= 1;
            }
        }

        private void Btn_Prim_One_Click(object sender, RoutedEventArgs e)
        {
            if (elli.Height >= 35)
            {
                elli.Height -= 2;
                elli.Width -= 2;

            }
        }

        private void Btn_Second_Two_Click(object sender, RoutedEventArgs e)
        {
            if (elli.Height < 55)
            {
                elli.Height += 2;
                elli.Width += 2;
            }
        }
    }
 }

