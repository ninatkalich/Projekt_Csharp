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

namespace Csharp_projektzaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy DodajKlienta.xaml
    /// </summary>
    public partial class DodajKlienta : Window
    {
        gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();
        public DodajKlienta()
        {
            InitializeComponent();
        }

        private void dodaj_Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime thisDay = DateTime.Today;

            Klienci nowy_klient = new Klienci()
            {
                imie = odp1.Text,
                nazwisko = odp2.Text,
                płec = plec_combo.Text,
                pierwsza_rejestracja = thisDay
            };
            database.Klienci.Add(nowy_klient);
            database.SaveChanges();
            KlienciPage.dgrid.ItemsSource = database.Klienci.ToList();
            this.Hide();

        }
    }
}
