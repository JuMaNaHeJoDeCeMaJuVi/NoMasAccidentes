using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Request
{
    class clienteRequest
    {
        public string runRepLegal { get; set; }
        public string dvRepLegal { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correoRepLegal { get; set; }
        public string telefonoCelular { get; set; }
        public string telefonoFijo { get; set; }
        public string nombreCalle { get; set; }
        public string numeroDomicilio { get; set; }
        public string tipoDomicilio { get; set; }
        public string nombreComuna { get; set; }
        public string nombreUsuarioRep { get; set; }
        public string passwordRep { get; set; }
        public string runEmpresa { get; set; }
        public string dvEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string giroEmpresa { get; set; }
        public string casaMatriz { get; set; }
        public string correoElectronicoEmpresa { get; set; }
        public byte escritura { get; set; }
        public string numeroCasaMatriz { get; set; }
        public string telefonoEmpresa { get; set; }

        public int regionID { get; set; }
    }
}
