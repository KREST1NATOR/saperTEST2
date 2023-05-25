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

namespace saperTEST2.View
{
    /// <summary>
    /// Логика взаимодействия для FieldEasy.xaml
    /// </summary>
    public partial class FieldEasy : Page
    {
        public FieldEasy()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button[] field = new Button[9];
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    Button button = new Button();
                    button.Height = 20;
                    button.Width = 20;
                    button.Margin = new Thickness(0 + i * -40, -150, -160, 0 + j * -40);
                    grid.Children.Add(button);
                }
            }
        }
    }
}
