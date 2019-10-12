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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbPapeleria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdArticulos.Children.Clear();
        }

        private void BtnAgregar(object sender, RoutedEventArgs e)
        {
            switch (cbPapeleria.SelectedIndex)
            {

                case 0: //Libros
                    grdArticulos.Children.Add(new Libros());
                break;



                case 1: //Cuadernos
                    grdArticulos.Children.Add(new Cuadernos());
                break;



                case 2: //Revista
                    grdArticulos.Children.Add(new Revista());
                break;



                case 3: //Cuentos
                    grdArticulos.Children.Add(new Cuentos());
                break;



                case 4: //Periodicos
                    grdArticulos.Children.Add(new Periodicos());
                break;



                case 5: //Agenda
                    grdArticulos.Children.Add(new Agenda());
                break;

            }
        }
    }
}