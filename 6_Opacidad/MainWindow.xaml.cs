using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace _6_Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image imagen;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            imagen = sender as Image;
            imagen.Opacity = 1;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            imagen = sender as Image;
            imagen.Opacity = 0.5;
        }
    }
}
