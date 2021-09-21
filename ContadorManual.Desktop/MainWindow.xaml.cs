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

namespace ContadorManual.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _Conteo; 
        public MainWindow()
        {
            InitializeComponent();
            _Conteo = 1; 
            ConteoLabel.Content = _Conteo;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _Conteo++;
            ConteoLabel.Content = _Conteo;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            _Conteo = 0;
            ConteoLabel.Content = _Conteo;
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
