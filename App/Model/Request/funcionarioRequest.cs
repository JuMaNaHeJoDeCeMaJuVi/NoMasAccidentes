using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Request
{
    class funcionarioRequest
    {
        public int idFuncionario { get; set; }
        public string runFuncionario { get; set; }
        public string dvFuncionario { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string correoElectronico { get; set; }
        public int cargo { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
    }
}
