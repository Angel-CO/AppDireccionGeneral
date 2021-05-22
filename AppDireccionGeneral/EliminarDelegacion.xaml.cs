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
    /// Interaction logic for EliminarDelegacion.xaml
    /// </summary>
    public partial class EliminarDelegacion : Window
    {
        public EliminarDelegacion()
        {
            InitializeComponent();
        }
        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuDelegacionMunicipal menuDelegacionMunicipal = new MenuDelegacionMunicipal();
            menuDelegacionMunicipal.Show();
            this.Close();
        }
    }
}
