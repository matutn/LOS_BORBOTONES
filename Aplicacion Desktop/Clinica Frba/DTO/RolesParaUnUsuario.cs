using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DataTransferObjects
{
    class RolesParaUnUsuario
    {
        public String Nombre_Rol = "";

        public RolesParaUnUsuario() { }
        
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;

            Rol r = obj as Rol;
            if ((System.Object)r == null)
                return false;
            else
                if (r.Nombre == this.Nombre_Rol)
                    return true;

            RolesParaUnUsuario rpu = obj as RolesParaUnUsuario;
            if ((System.Object)rpu == null)
                return false;

            return rpu.Nombre_Rol == this.Nombre_Rol;
        }

        public override int GetHashCode()
        {
            return int.Parse(this.Nombre_Rol);
        }
    }

}
