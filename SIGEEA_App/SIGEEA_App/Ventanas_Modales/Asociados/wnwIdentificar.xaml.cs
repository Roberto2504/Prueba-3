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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using SIGEEA_BL;
using SIGEEA_BO;
using SIGEEA_App.Ventanas_Modales.Personas;

namespace SIGEEA_App.Ventanas_Modales.Asociados
{
    /// <summary>
    /// Interaction logic for wnwIdentificar.xaml
    /// </summary>
    public partial class wnwIdentificar : Window
    {
        public wnwIdentificar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            AsociadoMantenimiento Asociado = new AsociadoMantenimiento();
            wnwRegistrarPersona ventana = new wnwRegistrarPersona(pTipoPersona: "Asociado", pAsociado: Asociado.AutenticaAsociado(txbInformacion.Text),pEmpleado:null);
            ventana.ShowDialog();
        }
    }
}
