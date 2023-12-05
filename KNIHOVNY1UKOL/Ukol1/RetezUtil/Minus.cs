using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetezUtil
{
    public class Minus
    {
        /// <summary>
        /// Odecteni
        /// </summary>
        string veta;
        public Minus(string veta)
        {
            this.veta = veta;
        }

        static public string operator -(Minus x, Minus y)
        {
            return x.veta.Replace(y.veta, "");
        }
    }
}
