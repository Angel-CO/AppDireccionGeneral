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

namespace Prototipos_IvanaCorrea
{
    /// <summary>
    /// Lógica de interacción para ModificarDelegacion.xaml
    /// </summary>
    public partial class ModificarDelegacion : Window
    {
        public ModificarDelegacion()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuDelegacionMunicipal menuDelegacionMunicipal = new MenuDelegacionMunicipal();
            menuDelegacionMunicipal.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
