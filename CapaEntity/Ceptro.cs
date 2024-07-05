using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Ceptro
    {
        public int Id { get; set; } // Autonumérico, Clave primaria
        public string Name { get; set; } // Nombre del CETPRO
        public string CodeModular { get; set; } // Código modular
        public string ManagementType{ get; set; } // Tipo de gestión
        public string Ugel { get; set; } // UGEL
        public string ResolutionAuth { get; set; } // Resolución de autorización
        public string ResolutionAuthProgram { get; set; } // Resolución de autorización
        public string PlaceService { get; set; } // Lugar donde se presta el servicio
        public string District { get; set; } // Distrito
        public string Departament { get; set; } // Departamento
        public string Province { get; set; } // Provincia
        public string Direction { get; set; } // Dirección
        public string Phone { get; set; } // Teléfono
        public string Email { get; set; } // Correo electrónico institucional
        public string PageWeb { get; set; } // Página WEB
        public string ProgramStudies { get; set; } // Programa de estudios
        public string InformativeLevel { get; set; }
    }
}
