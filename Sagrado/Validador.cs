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

}
}
