using AppDireccionGeneral.vista;
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

namespace AppDireccionGeneral
{
    /// <summary>
    /// Interaction logic for DetallesReporte.xaml
    /// </summary>
    public partial class DetallesReporte : Window
    {
        public DetallesReporte()
        {
            InitializeComponent();
            cargarImagenes();
        }
        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            ListaReportes listaReportes = new ListaReportes();
            listaReportes.Show();
            this.Close();
        }

        private void cargarImagenes()
        {
            Image image01 = new Image();
            Image image02 = new Image();
            Image image03 = new Image();
            Image image04 = new Image();

            image01.Source = new BitmapImage(new Uri("Images/choque01.jpg", UriKind.Relative));
            image02.Source = new BitmapImage(new Uri("Images/choque02.jpg", UriKind.Relative));
            image03.Source = new BitmapImage(new Uri("Images/choque03.jpg", UriKind.Relative));
            image04.Source = new BitmapImage(new Uri("Images/choque04.jpg", UriKind.Relative));

            image01.Height = 200;
            image02.Height = 200;
            image03.Height = 200;
            image04.Height = 200;

            wp_imagenes.Children.Add(image01);
            wp_imagenes.Children.Add(image02);
            wp_imagenes.Children.Add(image03);
            wp_imagenes.Children.Add(image04);

            Image image05 = new Image();
            image05.Source = new BitmapImage(new Uri("Images/choque01.jpg", UriKind.Relative));
            image05.Height = 200;
            wp_imagenes.Children.Add(image05);
        }
    }
}
