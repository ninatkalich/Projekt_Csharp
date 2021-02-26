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
  

    public partial class PracownicyPage : Window
    {
        gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();
        public static DataGrid dgrid;
         int wybranausluga=0;
        private void load_kliencitabela()
        {
            switch(wybranausluga)
            {
                case 1:
                 
                    var query =
       from Pracownicy in database.Pracownicy
       where Pracownicy.Pilęgnacja_Dłoni == true
       select new { Pracownicy.imie, Pracownicy.nazwisko, Pracownicy.płeć, Pracownicy.Pilęgnacja_Dłoni, Pracownicy.Makijarz, Pracownicy.Stylizacja_brwi, Pracownicy.Masaże };

                    Pracownicy_data.ItemsSource = query.ToList();
                    dgrid = Pracownicy_data;

                    break;

                case 2:
                     query =
       from Pracownicy in database.Pracownicy
       where Pracownicy.Makijarz == true
       select new { Pracownicy.imie, Pracownicy.nazwisko, Pracownicy.płeć, Pracownicy.Pilęgnacja_Dłoni, Pracownicy.Makijarz, Pracownicy.Stylizacja_brwi, Pracownicy.Masaże };

                    Pracownicy_data.ItemsSource = query.ToList();
                    dgrid = Pracownicy_data;

                    break;
                case 3:

                    query =
      from Pracownicy in database.Pracownicy
      where Pracownicy.Stylizacja_brwi == true
      select new { Pracownicy.imie, Pracownicy.nazwisko, Pracownicy.płeć, Pracownicy.Pilęgnacja_Dłoni, Pracownicy.Makijarz, Pracownicy.Stylizacja_brwi, Pracownicy.Masaże };

                    Pracownicy_data.ItemsSource = query.ToList();
                    dgrid = Pracownicy_data;
                    break;

                case 4:
                    query =
      from Pracownicy in database.Pracownicy
      where Pracownicy.Masaże == true
      select new { Pracownicy.imie, Pracownicy.nazwisko, Pracownicy.płeć, Pracownicy.Pilęgnacja_Dłoni, Pracownicy.Makijarz, Pracownicy.Stylizacja_brwi, Pracownicy.Masaże };

                    Pracownicy_data.ItemsSource = query.ToList();
                    dgrid = Pracownicy_data;
                    break;
                default:
                    MessageBox.Show("Prosze wybrać zabieg aby wyswielić listę Pracowników");
                    break;

            }
         

        }

        public PracownicyPage(int zabieg_id)
        {
            wybranausluga = zabieg_id;
            InitializeComponent();

            load_kliencitabela();

            
        }

        private void Pracownicy_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int Id = (Pracownicy_data.SelectedItem as Pracownicy).Id;
            MainWindow.wypelnij_pracownika(Id);

            this.Hide();
        }
    }
}
