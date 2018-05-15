using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagrado
{
    class Validador
    {

        public static bool campoPreenchido(String txt)
        {
            if (txt == string.Empty)
            {
                return false;
            }
            else
                return true;
        }

        public static String FormataCpfAndRg(String typeFormat)
        {
            typeFormat = typeFormat.Replace(",", "");
            typeFormat = typeFormat.Replace("-", "");
            return typeFormat;
        }

        public static String FormataTelAndCel(String typeFormat)
        {
            typeFormat = typeFormat.Replace("(", "");
            typeFormat = typeFormat.Replace(")", "");
            typeFormat = typeFormat.Replace(" ", "");
            typeFormat = typeFormat.Replace("-", "");
            return typeFormat;
        }

        public static String FormataTel(String typeFormat)
        {
            return typeFormat.Substring(2,8);
        }

        public static String FormataCel(String typeFormat)
        {
            return typeFormat.Substring(2, 9);
        }
    }
}
