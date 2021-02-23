using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_projektzaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy DostepneUsługipage.xaml
    /// </summary>
    public partial class DostepneUsługipage : Window
    {
        public DostepneUsługipage()
        {
            InitializeComponent();
            load_uslugi();
        }

        private gabinet_kosmetycznyEntities database = new gabinet_kosmetycznyEntities();

        public static DataGrid dgrid;

        private void load_uslugi()
        {
            uslugi_data.ItemsSource = database.Zabieg.ToList();
            dgrid = uslugi_data;
        }
    }
}