using GestionAvituallamientos.Modelo;
using GestionAvituallamientos.Vista;
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

namespace GestionAvituallamientos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Logica logica;

        public MainWindow()
        {
            InitializeComponent();
            logica = new Logica();
        }

        private void btGestionAvitualla_Click(object sender, RoutedEventArgs e)
        {
            
            GestionAltaAvituallamientos gAltaAvi = new GestionAltaAvituallamientos(logica);
            gAltaAvi.ShowDialog();
        }

        private void btGestionProductos_Click(object sender, RoutedEventArgs e)
        {
            VentanaProducto producto = new VentanaProducto(logica);
            producto.ShowDialog();
        }
    }
}
