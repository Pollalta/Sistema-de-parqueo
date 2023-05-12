using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATEDRA
{
    internal class Logins
    {
        public Boolean verificarDui(String dui)
        {
            Boolean resultado = false;
            if (!Regex.IsMatch(dui, "^\\d{8}-\\d{1}$"))
            {
                resultado = false;
                return resultado;
            }
            else
            {
                resultado = true;
                return resultado;
            }
           
        }
        public  bool VerificarDUI(string numeroDUI)
        {
            // Verificamos que el número tenga 9 caracteres
            if (numeroDUI.Length != 9)
            {
                return false;
            }

            // Verificamos que todos los caracteres sean dígitos
            foreach (char c in numeroDUI)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Verificamos que los primeros 8 caracteres sean números y el último un dígito o la letra 'V'
            if (!Regex.IsMatch(numeroDUI, @"^\d{8}[0-9V]$"))
            {
                return false;
            }

            // Verificamos el dígito verificador
            int digitoVerificador = int.Parse(numeroDUI.Substring(8));
            int suma = 0;
            for (int i = 0; i < 8; i++)
            {
                suma += int.Parse(numeroDUI[i].ToString()) * (i + 2);
            }
            int resto = suma % 10;
            int digitoCalculado = (resto == 0) ? 0 : (10 - resto);

            if (digitoCalculado == digitoVerificador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
