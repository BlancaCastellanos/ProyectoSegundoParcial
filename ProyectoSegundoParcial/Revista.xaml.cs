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
    /// Lógica de interacción para Revista.xaml
    /// </summary>
    public partial class Revista : UserControl
    {
        public Revista()
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

        private void TbCod_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }

        private void TbDescr_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }

        private void TbCosto_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }

        private void TbPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }

        private void TbCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }
        private void TbProveedor_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtaviso.Visibility = Visibility.Hidden;
        }

    }
}
