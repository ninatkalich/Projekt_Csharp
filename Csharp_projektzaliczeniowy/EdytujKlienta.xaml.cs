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
    /// Logika interakcji dla klasy EdytujKlienta.xaml
    /// </summary>
    public partial class EdytujKlienta : Window
    {
        gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();
        int id_edytowane_klienta;
        public EdytujKlienta(int wybrany_klient)
        {
            id_edytowane_klienta = wybrany_klient;
            InitializeComponent();
            wprowadz_klienta();
        }

        private void wprowadz_klienta()
        {
            Klienci edytowany = new Klienci();
            edytowany.Id = id_edytowane_klienta;

            edytowany = database.Klienci.Where(x => x.Id == edytowany.Id).FirstOrDefault();
            odp1.Text = edytowany.imie;
            odp2.Text = edytowany.nazwisko;
            plec_combo.Text = edytowany.płec;





        }

        private void edytuj_Button_Click(object sender, RoutedEventArgs e)
        {
            Klienci edytowany = new Klienci();
            edytowany.Id = id_edytowane_klienta;

            edytowany = database.Klienci.Where(x => x.Id == edytowany.Id).FirstOrDefault();
           edytowany.imie=odp1.Text;
             edytowany.nazwisko=odp2.Text;
           edytowany.płec = plec_combo.Text;
            database.SaveChanges();
            KlienciPage.dgrid.ItemsSource= database.Klienci.ToList();
            this.Hide();

        }
    }
}
