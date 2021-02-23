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

namespace Csharp_projektzaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textDosteepneuslugi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DostepneUsługipage oknoDostepneUsługi = new DostepneUsługipage();
            oknoDostepneUsługi.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            umowwizyte oknoumowwizyte = new umowwizyte();
            oknoumowwizyte.ShowDialog();
        }
    }
}
