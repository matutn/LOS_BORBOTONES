using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DTO
{

    public class RecetaDTO
    {

        public static String nombreTabla = "LOS_BORBOTONES.Receta";
        public static String primaryKey = "rece_IdReceta";
        public static List<String> primaryKeys;
        public string rece_IdReceta { get; set; }
        public string rece_Estado { get; set; }
        public string rece_IdConsulta { get; set; }
        public List<MedicamentoDTO> medicamentos;




        //---------Constructores-------------
        public RecetaDTO() { }


        public RecetaDTO(string IdReceta,
                        string Estado,
                        string consulta,
                        List<MedicamentoDTO> medic)
        {

            this.rece_IdReceta = IdReceta;
            this.rece_Estado = Estado;
            this.rece_IdConsulta = consulta;
            this.medicamentos = medic;
        }



    }
}

