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

namespace MySuperCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button _buttonCancel;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded1;
        }

        private void MainWindow_Loaded1(object sender, RoutedEventArgs e)
        {
            _buttonCancel = new Button
            {
                Content = "Hey, do not press me!!!",
                FontFamily = new FontFamily("Franklin Gothic"),
                FontSize = 20,
                Foreground = Brushes.White,
                Background = Brushes.Brown,
                Margin = new Thickness(350, 350, 15, 15)
            };


            gridPanel.Children.Add (_buttonCancel);
        }
       

        

        private void buttonPress_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wow!");
        }
    }
}
