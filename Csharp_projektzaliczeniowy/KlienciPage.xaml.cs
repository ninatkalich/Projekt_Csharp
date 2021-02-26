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
    
    public partial class KlienciPage : Window
    {

        int Id;
        public KlienciPage()
        {
            InitializeComponent();
            load_kliencitabela();
        }

        gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();

        public static DataGrid dgrid;

        private void load_kliencitabela()
        {
            Klienci_data.ItemsSource = database.Klienci.ToList();
            dgrid = Klienci_data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajKlienta oknoDodajKlienta = new DodajKlienta();
            oknoDodajKlienta.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                Id = (Klienci_data.SelectedItem as Klienci).Id;
                EdytujKlienta oknoEdytujKlienta = new EdytujKlienta(Id);
                oknoEdytujKlienta.Show();
            
         
           


        }

        public void Klienci_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Id = (Klienci_data.SelectedItem as Klienci).Id;
            MainWindow.wypelnij_klijenta(Id);
            // umowwizyte oknoumowwizyte = new umowwizyte();
            // oknoumowwizyte.uzuplnik_klienta(Id);
            //tu skonczcyłem tu trzeba otworzyc okno z wizyta i ponumerowanym id 
            this.Hide();
        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Id = (Klienci_data.SelectedItem as Klienci).Id;

            database.Klienci.Remove((from x in database.Klienci
                                     where x.Id == Id
                                     select x).Single());
            database.SaveChanges();
            Klienci_data.ItemsSource = database.Klienci.ToList();
        }


        
    }
}
