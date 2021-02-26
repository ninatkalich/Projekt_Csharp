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
      public static umowwizyte oknoumowwizyte = new umowwizyte();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void textDosteepneuslugi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DostepneUsługipage oknoDostepneUsługi = new DostepneUsługipage();
            oknoDostepneUsługi.ShowDialog();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            oknoumowwizyte.ShowDialog();
        }
        public static void wypelnij_klijenta(int id_wybranego_klienta)
        {
            oknoumowwizyte.Wybrany_klient.Text = id_wybranego_klienta.ToString();
        }
        public static void wypelnij_zabieg(int id_wybranego_zabiegu)
        {
            oknoumowwizyte.Wybrany_zabieg.Text = id_wybranego_zabiegu.ToString();
            oknoumowwizyte.sprawdz_pracownika(id_wybranego_zabiegu);

        }
        public static void wypelnij_pracownika(int id_wybranego_pracownika)
        {
            oknoumowwizyte.Wybrany_pracownik.Text = id_wybranego_pracownika.ToString();
        }



    }
}
