using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{

    internal class PhoneCheck
    {
        public const string motif = @"^\(?(69)\)?([0-9]{8})$";

        public static bool IsPhoneNbr(string number)
        {
            //check phone start 69 and length=10
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }
    }
}
