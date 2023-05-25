using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace saperTEST2.View
{
    /// <summary>
    /// Логика взаимодействия для Play.xaml
    /// </summary>
    public partial class Play : Page
    {
        public Play()
        {
            InitializeComponent();
        }

        private void Button_Click_Easy(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FieldEasy());
        }

        private void Button_Click_Normal(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FieldNormal());
        }

        private void Button_Click_Hard(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FieldExpert());
        }
    }
}
