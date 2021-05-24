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
    /// Lógica de interacción para ModificarUsuario.xaml
    /// </summary>
    public partial class ModificarUsuario : Window
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuUsuarios menuUsuarios = new MenuUsuarios();
            menuUsuarios.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
