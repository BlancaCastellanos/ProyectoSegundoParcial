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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Periodicos.xaml
    /// </summary>
    public partial class Periodicos : UserControl
    {
        public Periodicos()
        {
            InitializeComponent();

            txtaviso.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            //Condicional (dudas - checar)

            if (tbCodA.Text == string.Empty ||
                tbDescP.Text == string.Empty ||
                tbCosto.Text == string.Empty ||
                tbPrecipP.Text == string.Empty ||
                tbProv.Text == string.Empty ||
                tbCantidad.Text == string.Empty)
            {
                txtaviso.Visibility = Visibility.Visible;
            }


            else
            {
                grdFormularioArt.Children.Clear();
            }

        }

        private void BtnCancelar(object sender, RoutedEventArgs e)
        {
            grdFormularioArt.Children.Clear();
        }

        private void Cod_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbCodA.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }

        private void Descr_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbDescP.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }

        private void Costo_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbCosto.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }

        private void Precio_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPrecipP.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }

        private void Cantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbCantidad.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }
        private void Proveedor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbProv.Text == "")
            {
                txtaviso.Visibility = Visibility.Visible;
            }
            else
            {
                txtaviso.Visibility = Visibility.Hidden;
            }
        }

    }
}

