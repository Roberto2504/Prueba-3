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

using MahApps.Metro.Controls; 
using MahApps.Metro.Controls.Dialogs;

namespace SIGEEA_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            ShowCloseButton = false;
            btnSalir.Click += BtnSalir_Click;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            tiAsociados.GotFocus += TiAsociados_GotFocus;
            tiEmpleados.GotFocus += TiEmpleados_GotFocus;
            tiProductos.GotFocus += TiProductos_GotFocus;

            frmAsociados.Navigate(new Uri("/Paginas/Pag_Asociados.xaml", UriKind.RelativeOrAbsolute));
            frmEmpleados.Navigate(new Uri("/Paginas/Pag_Empleados.xaml", UriKind.RelativeOrAbsolute));
            frmProductos.Navigate(new Uri("/Paginas/Pag_Productos.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TiProductos_GotFocus(object sender, RoutedEventArgs e)
        {
            frmAsociados.Refresh();
            frmEmpleados.Refresh();
        }

        private void TiEmpleados_GotFocus(object sender, RoutedEventArgs e)
        {
            frmAsociados.Refresh();
            frmProductos.Refresh();
        }

        private void TiAsociados_GotFocus(object sender, RoutedEventArgs e)
        {
            frmProductos.Refresh();
            frmEmpleados.Refresh();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
