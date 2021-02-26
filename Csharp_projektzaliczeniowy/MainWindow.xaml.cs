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
        public static umowwizyte oknoumowwizyte;

        public static Wizyta nowa_wizyta = new Wizyta();

        static gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();
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
            oknoumowwizyte = new umowwizyte();
        oknoumowwizyte.ShowDialog();
        }
        public static void wypelnij_klijenta(int id_wybranego_klienta)
        {
            Klienci wybrany_klient = new Klienci();
            nowa_wizyta.Klient_id = id_wybranego_klienta;

            wybrany_klient.Id=id_wybranego_klienta;
            wybrany_klient = database.Klienci.Where(x => x.Id == wybrany_klient.Id).FirstOrDefault();

            oknoumowwizyte.Wybrany_klient.Text = wybrany_klient.imie.Trim()+" "+wybrany_klient.nazwisko.Trim();




       
           // Pracownicy_data.ItemsSource = query.ToList();
        }
        public static void wypelnij_zabieg(int id_wybranego_zabiegu)
        {
            nowa_wizyta.Usługa_id = id_wybranego_zabiegu;
            Zabieg wybrany_zabieg = new Zabieg();
            wybrany_zabieg.Id = id_wybranego_zabiegu;
            wybrany_zabieg = database.Zabieg.Where(x => x.Id == wybrany_zabieg.Id).FirstOrDefault();
            oknoumowwizyte.Wybrany_zabieg.Text = wybrany_zabieg.nazwa;
            oknoumowwizyte.sprawdz_pracownika(id_wybranego_zabiegu);

        }
        public static void wypelnij_pracownika(int id_wybranego_pracownika)
        {
            nowa_wizyta.Pracownik_id = id_wybranego_pracownika;
            Pracownicy wybrany_pracownik = new Pracownicy();
            wybrany_pracownik.Id = id_wybranego_pracownika;
            wybrany_pracownik = database.Pracownicy.Where(x => x.Id == wybrany_pracownik.Id).FirstOrDefault();

            oknoumowwizyte.Wybrany_pracownik.Text = wybrany_pracownik.imie.Trim() + " " + wybrany_pracownik.nazwisko.Trim();
            
        }
        public static void createvisit()
        {
            if (nowa_wizyta.Klient_id != 0 && nowa_wizyta.Usługa_id != 0 && nowa_wizyta.Pracownik_id != 0&& oknoumowwizyte.Wybrana_data.Text!="")
            {
                nowa_wizyta.data = oknoumowwizyte.Wybrana_data.Text;
                database.Wizyta.Add(nowa_wizyta);
                database.SaveChanges();
                oknoumowwizyte.Hide();
            }
            else MessageBox.Show("Uzupełnij wszystkie pola P.S nacisnij na nie 2 razy l.p.m");
        }



    }
}
