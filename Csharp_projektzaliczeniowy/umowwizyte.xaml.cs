using System.Windows;

namespace Csharp_projektzaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy umowwizyte.xaml
    /// </summary>
    public partial class umowwizyte : Window
    {
       
         int wybrany_zabieg;
        public umowwizyte()
        {
            InitializeComponent();
            

        }

    public  void sprawdz_pracownika(int id_wybranego_zabiegu) 
        {

            wybrany_zabieg = id_wybranego_zabiegu;
           
                      


        }
     

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed && e.ClickCount == 2)
            {
                KlienciPage oknoKlienciPage = new KlienciPage();
                oknoKlienciPage.ShowDialog();

            }
        }

        private void Wybrany_zabieg_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed && e.ClickCount == 2)
            {
                DostepneUsługipage oknoDostepneUsługipage = new DostepneUsługipage();
                oknoDostepneUsługipage.ShowDialog();

            }
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed && e.ClickCount == 2)
            {
                
                PracownicyPage oknoPracownicyPage = new PracownicyPage(wybrany_zabieg);
                oknoPracownicyPage.ShowDialog();

            }
        }
    }
}