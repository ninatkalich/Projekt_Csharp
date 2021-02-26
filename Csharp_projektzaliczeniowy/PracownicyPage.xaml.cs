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
        int wybranausluga = 0;
        private void load_kliencitabela()
        {

            switch (wybranausluga)
            {
                case 1:

                    Pracownicy_data.ItemsSource = database.Pracownicy.Where(x => x.Pilęgnacja_Dłoni == true).ToList();


                    break;

                case 2:
                   Pracownicy_data.ItemsSource= database.Pracownicy.Where(x => x.Makijarz == true).ToList();


                    break;
                case 3:

                    Pracownicy_data.ItemsSource = database.Pracownicy.Where(x => x.Stylizacja_brwi == true).ToList();

                    break;

                case 4:
                    Pracownicy_data.ItemsSource = database.Pracownicy.Where(x => x.Masaże == true).ToList();

                    break;
                default:
                    MessageBox.Show("Prosze wybrać zabieg aby wyswielić listę Pracowników");
                    break;

            }
            dgrid = Pracownicy_data;


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
