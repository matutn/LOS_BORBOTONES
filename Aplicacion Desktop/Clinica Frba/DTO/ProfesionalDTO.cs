using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DTO
{
    public class ProfesionalDTO
    {
        public string IdProfesional { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDni { get; set; }
        public string Dni { get; set; }
        public string NroMatricula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }

        public ProfesionalDTO() { }

        public ProfesionalDTO
        (
             String IdProfesional,
             String NombreUsuario,
             String Nombre,
             String Apellido,
             String TipoDni,
             String Dni,
             String NroMatricula,
             String Direccion,
             String Telefono,
             String Mail,
             String FechaNacimiento,
             String Sexo,
             String Estado
        )
        {
            this.IdProfesional = IdProfesional;
            this.NombreUsuario = NombreUsuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.TipoDni = TipoDni;
            this.Dni = Dni;
            this.NroMatricula = NroMatricula;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Mail = Mail;
            this.FechaNacimiento = FechaNacimiento;
            this.Sexo = Sexo;
            this.Estado = Estado;
        }
    }
}
