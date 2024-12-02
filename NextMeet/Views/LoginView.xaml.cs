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
using NextMeet.Views;

namespace NextMeet.Views
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void TxtUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TxtUsuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TxtContrasena_GotFocus(object sender, RoutedEventArgs e)
        {
            placeholderContrasena.Visibility = Visibility.Collapsed;
        }

        private void TxtContrasena_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Password))
            {
                placeholderContrasena.Visibility = Visibility.Visible;
            }
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para el botón "Iniciar Sesión"
            if (txtUsuario.Text == "admin" && txtContrasena.Password == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                lblError.Visibility = Visibility.Visible;
            }
        }
    }
}