using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program_1
{
    public class RegexValidator//"Jeśli w programie nie zostanie przeprowadzona pełna walidacja jeście raz opróć formularzu rejestracji ('registration frm'), można wcześniej dodać jego do form1.sc i usunąć klase"
    {
        public static bool isValidatoinPassword(string password)
        {
            string pattern = @"(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
