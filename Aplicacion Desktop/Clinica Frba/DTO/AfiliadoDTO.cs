using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DTO
{
    public class AfiliadoDTO
    {
        public string IdAfiliado { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDni { get; set; }
        public string Dni { get; set; }
        public string IdPlan { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string CantPersonas { get; set; }
        public string CantidadConsultas { get; set; }
        public string Estado { get; set; }

        public AfiliadoDTO() { }

        public AfiliadoDTO
        (
             String IdAfiliado,
             String NombreUsuario,
             String Nombre,
             String Apellido,
             String TipoDni,
             String Dni,
             String IdPlan,
             String Direccion,
             String Telefono,
             String Mail,
             String FechaNacimiento,
             String Sexo,
             String EstadoCivil,
             String CantPersonas,
             String CantidadConsultas,
             String Estado
        )
        {
            this.IdAfiliado = IdAfiliado;
            this.NombreUsuario = NombreUsuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.TipoDni = TipoDni;
            this.Dni = Dni;
            this.IdPlan = IdPlan;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Mail = Mail;
            this.FechaNacimiento = FechaNacimiento;
            this.Sexo = Sexo;
            this.EstadoCivil = EstadoCivil;
            this.CantPersonas = CantPersonas;
            this.CantidadConsultas = CantidadConsultas;
            this.Estado = Estado;
        }
    }
}
