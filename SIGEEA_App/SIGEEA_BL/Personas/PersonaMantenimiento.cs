using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGEEA_BO;

namespace SIGEEA_BL
{
    public class PersonaMantenimiento
    {
        /// <summary>
        /// Registrar una persona nueva
        /// </summary>
        /// <param name="persona"></param>
        public void RegistrarPersona(SIGEEA_Persona persona)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.SIGEEA_Personas.InsertOnSubmit(persona);
            dc.SubmitChanges();
        }
        
        /// <summary>
        /// Modificar datos de la persona
        /// </summary>
        /// <param name="persona"></param>
        public void ModificarPersona(SIGEEA_Persona persona)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            SIGEEA_Persona pers = dc.SIGEEA_Personas.First(c => c.PK_Id_Persona == persona.PK_Id_Persona);
            pers.Cedula_Persona = persona.Cedula_Persona;
            pers.FecNacimiento_Persona = persona.FecNacimiento_Persona;
            pers.FK_Id_Direccion = persona.FK_Id_Direccion;
            pers.FK_Id_Nacionalidad = persona.FK_Id_Nacionalidad;
            pers.Genero_Persona = persona.Genero_Persona;
            pers.PriApellido_Persona = persona.PriApellido_Persona;
            pers.PriNombre_Persona = persona.PriNombre_Persona;
            pers.SegApellido_Persona = persona.SegApellido_Persona;
            pers.SegNombre_Persona = persona.SegNombre_Persona;
            dc.SubmitChanges();
        }        

        public List<string> ListarNacionalidades()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<string> nacionalidades = (from c in dc.SIGEEA_Nacionalidads select c.Nombre_Nacionalidad).ToList();
            return nacionalidades;
        }
    }
}
