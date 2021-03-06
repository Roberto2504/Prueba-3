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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using SIGEEA_BL;
using SIGEEA_BO;

namespace SIGEEA_App.Ventanas_Modales.Personas
{
    /// <summary>
    /// Interaction logic for wnwRegistrarPersona.xaml
    /// </summary>
    public partial class wnwRegistrarPersona : MetroWindow
    {
        string tipoPersona;
        SIGEEA_Persona nuevaPersona;
        bool editar;
        int pk_Persona;
        public wnwRegistrarPersona(string pTipoPersona, SIGEEA_spObtenerAsociadoResult pAsociado, SIGEEA_spObtenerEmpleadoResult pEmpleado)
        {
            InitializeComponent();
            tipoPersona = pTipoPersona;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnRegistrar.Click += BtnRegistrar_Click;
            PersonaMantenimiento persona = new PersonaMantenimiento();
            cbxNacionalidad.ItemsSource = persona.ListarNacionalidades();
            if (pAsociado != null)//Si se desea editar un asociado
            {
                editar = true;
                CargarInformacionAsociado(pAsociado);
                pk_Persona = pAsociado.PK_Id_Persona;
            }
            if(pEmpleado != null)//Si se desea editar un empleado
            {
                editar = true;
                CargarInformacionEmpleado(pEmpleado);
                pk_Persona = pEmpleado.PK_Id_Persona;
            }
        }

        public void RegistrarPersona()
        {
            nuevaPersona = new SIGEEA_Persona();
            nuevaPersona.Cedula_Persona = txbCedula.Text;
            nuevaPersona.FecNacimiento_Persona = dtpFecNacimiento.SelectedDate.Value;
            nuevaPersona.FK_Id_Direccion = null;
            nuevaPersona.FK_Id_Nacionalidad = cbxNacionalidad.SelectedIndex + 1;
            ComboBoxItem item = (ComboBoxItem)cbxGenero.SelectedItem;
            nuevaPersona.Genero_Persona = item.Content.ToString();
            nuevaPersona.PriApellido_Persona = txbPriApellido.Text;
            nuevaPersona.PriNombre_Persona = txbPriNombre.Text;
            nuevaPersona.SegApellido_Persona = txbSegApellido.Text;
            nuevaPersona.SegNombre_Persona = txbSegNombre.Text;
        }

        public void CargarInformacionAsociado(SIGEEA_spObtenerAsociadoResult pAsociado)
        {
            txbCedula.Text = pAsociado.Cedula_Persona;
            txbPriNombre.Text = pAsociado.PriNombre_Persona;
            txbSegNombre.Text = pAsociado.SegNombre_Persona;
            txbPriApellido.Text = pAsociado.PriApellido_Persona;
            txbSegApellido.Text = pAsociado.SegApellido_Persona;
            dtpFecNacimiento.Text = pAsociado.FecNacimiento_Persona.ToString();
            if (pAsociado.Genero_Persona == "M") cbxGenero.SelectedIndex = 0; else cbxGenero.SelectedIndex = 1;
            cbxNacionalidad.SelectedIndex = pAsociado.FK_Id_Nacionalidad - 1;
        }

        public void CargarInformacionEmpleado(SIGEEA_spObtenerEmpleadoResult pEmpleado)
        {
            txbCedula.Text = pEmpleado.Cedula_Persona;
            txbPriNombre.Text = pEmpleado.PriNombre_Persona;
            txbSegNombre.Text = pEmpleado.SegNombre_Persona;
            txbPriApellido.Text = pEmpleado.PriApellido_Persona;
            txbSegApellido.Text = pEmpleado.SegApellido_Persona;
            dtpFecNacimiento.Text = pEmpleado.FecNacimiento_Persona.ToString();
            if (pEmpleado.Genero_Persona == "M") cbxGenero.SelectedIndex = 0; else cbxGenero.SelectedIndex = 1;
            cbxNacionalidad.SelectedIndex = pEmpleado.FK_Id_Nacionalidad - 1;
            txbAdicional.Text = pEmpleado.Observaciones_Escolaridad;
            chkEscribir.IsChecked = pEmpleado.Escribir_Escolaridad;
            chkLeer.IsChecked = pEmpleado.Leer_Escolaridad;
            cmbGradoAcad.SelectedIndex = pEmpleado.GradoAcad_Escolaridad - 1;
        }
        private void BtnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tipoPersona == "Asociado")
                {
                    RegistrarPersona();
                    if (editar == false)
                    {
                        AsociadoMantenimiento Asociado = new AsociadoMantenimiento();
                        SIGEEA_Asociado nuevoAsociado = new SIGEEA_Asociado();
                        nuevoAsociado.Estado_Asociado = true;
                        nuevoAsociado.FK_Id_Representante = null;
                        nuevoAsociado.FecIngreso_Asociado = DateTime.Today;
                        Asociado.RegistrarAsociado(nuevaPersona, nuevoAsociado);
                    }
                    else
                    {
                        nuevaPersona.PK_Id_Persona = pk_Persona;
                        PersonaMantenimiento Persona = new PersonaMantenimiento();
                        Persona.ModificarPersona(nuevaPersona);
                    }

                    MessageBox.Show("Su solicitud se ha concluido de manera correcta.");
                }

                else if (tipoPersona == "Empleado")
                {
                    grdPersona.Visibility = Visibility.Collapsed;
                    grdEmpleado.Visibility = Visibility.Visible;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar la información de manera correcta.");
            }
}

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegistrarPersona();
                nuevaPersona.PK_Id_Persona = pk_Persona;
                SIGEEA_Escolaridad nuevaEscolaridad = new SIGEEA_Escolaridad();
                nuevaEscolaridad.Leer_Escolaridad = chkLeer.IsChecked.GetValueOrDefault();
                nuevaEscolaridad.Escribir_Escolaridad = chkEscribir.IsChecked.GetValueOrDefault();
                nuevaEscolaridad.GradoAcad_Escolaridad = cmbGradoAcad.SelectedIndex + 1;
                nuevaEscolaridad.Observaciones_Escolaridad = txbAdicional.Text;
                EmpleadoMantenimiento empleadoMant = new EmpleadoMantenimiento();

                if (editar == false)
                {                  
                    SIGEEA_Empleado nuevoEmpleado = new SIGEEA_Empleado();                    
                    empleadoMant.RegistrarEmpleado(nuevaPersona, nuevoEmpleado, nuevaEscolaridad);
                }
                else
                {
                    empleadoMant.EditarEmpleado(nuevaPersona, nuevaEscolaridad);
                }

                MessageBox.Show("La solicitud realizada se finalizó con éxito.");
            }
            catch
            {
                MessageBox.Show("Error al realizar la solicitud.");
            }
        }
    }
}
