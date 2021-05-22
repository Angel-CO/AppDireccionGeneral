﻿using System;
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
    /// Interaction logic for MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void Btn_Usuario_Click(object sender, RoutedEventArgs e)
        {
            MenuUsuarios menuUsuarios = new MenuUsuarios();
            menuUsuarios.Show();
            this.Close();
        }

        private void Btn_DelegacionMunicipal_Click(object sender, RoutedEventArgs e)
        {
            MenuDelegacionMunicipal menuDelegacionMunicipal = new MenuDelegacionMunicipal();
            menuDelegacionMunicipal.Show();
            this.Close();
        }

        private void Btn_Chat_Click(object sender, RoutedEventArgs e)
        {
            Chat chat = new Chat();
            chat.Show();
            this.Close();

        }

        private void Btn_Reportes_Click(object sender, RoutedEventArgs e) {
            ListaReportes listaReportes = new ListaReportes();
            listaReportes.Show();
            this.Close();

        }
    }
}