using System.Windows;

namespace Csharp_projektzaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy umowwizyte.xaml
    /// </summary>
    public partial class umowwizyte : Window
    {
        public string PlaceholderText { get; set; }

        public umowwizyte()
        {
            InitializeComponent();
        }

   

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed && e.ClickCount == 2)
            {
                KlienciPage oknoKlienciPage = new KlienciPage();
                oknoKlienciPage.ShowDialog();

            }
        }
    }
}