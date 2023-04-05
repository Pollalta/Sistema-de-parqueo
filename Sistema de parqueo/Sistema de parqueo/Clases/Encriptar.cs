using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_de_parqueo.Clases
{
    internal class Encriptar
    {
        public Boolean verificarDui(String dui)
        {
            Boolean resultado = false;
            if (string.IsNullOrWhiteSpace(dui)) {
                resultado = false;
                return resultado;  }
            try
            {
                Regex.Match("^\\d{8}-\\d{1}$", dui);
                resultado = true;

            }
            catch (ArgumentException)
            {

               resultado= false;
            }
            return resultado;
        }
    }
}
