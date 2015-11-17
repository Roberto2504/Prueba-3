using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGEEA_BO;

namespace SIGEEA_BL
{
    public class AsociadoMantenimiento
    {
        /// <summary>
        /// Registrar asociado (se registra primero la persona y luego el asociado)
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="asociado"></param>
        public void RegistrarAsociado(SIGEEA_Persona persona, SIGEEA_Asociado asociado)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            PersonaMantenimiento nuevaPersona = new PersonaMantenimiento();
            nuevaPersona.RegistrarPersona(persona);
            asociado.FK_Id_Persona = persona.PK_Id_Persona;
            asociado.Codigo_Asociado = "F";
            asociado.Categoria_Asociado = 5;
            dc.SIGEEA_Asociados.InsertOnSubmit(asociado);
            dc.SubmitChanges();

            SIGEEA_Asociado modificarAsociado = new SIGEEA_Asociado();
            modificarAsociado = dc.SIGEEA_Asociados.First(c => c.PK_Id_Asociado == asociado.PK_Id_Asociado);
            modificarAsociado.Codigo_Asociado = "F" + modificarAsociado.PK_Id_Asociado.ToString() + persona.PriNombre_Persona[0] + persona.PriApellido_Persona[0] + persona.SegApellido_Persona[0];
            dc.SubmitChanges();
        }

        /// <summary>
        /// Eliminar asociado (cambia de estado).
        /// </summary>
        /// <param name="asociado"></param>

        public void EliminarAsociado(SIGEEA_Asociado asociado)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            SIGEEA_Asociado asoc = dc.SIGEEA_Asociados.First(c => c.PK_Id_Asociado == asociado.PK_Id_Asociado);
            asoc.Estado_Asociado = false;
            dc.SubmitChanges();
        }

        /// <summary>
        /// Hace la búsqueda del asociado que se desea ubicar
        /// </summary>
        /// <param name="codigo_cedula"></param>
        /// <returns></returns>
        public SIGEEA_spObtenerAsociadoResult AutenticaAsociado(string codigo_cedula)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            if (codigo_cedula.Length >= 9) //Si es una cédula
            {
                return dc.SIGEEA_spObtenerAsociado(cedula: codigo_cedula, codigoAsociado: null).FirstOrDefault();
            }

            else
            {
                return dc.SIGEEA_spObtenerAsociado(cedula: null, codigoAsociado: codigo_cedula).FirstOrDefault();
            }
        }
    }
}
