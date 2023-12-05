using System.Reflection.Emit;
using System.Text;

namespace RetezUtil
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="veta"></param>
        public static void Smaz(ref string veta)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(veta);

            for(int i = 0; i < stringBuilder.Length;) {
                if (stringBuilder[i] >= '0' && stringBuilder[i] <= '9')
                {
                    stringBuilder.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }   
            veta = stringBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="veta"></param>
        /// <param name="polozky"></param>
        public static void Zobraz(ref string veta, out string[] polozky)
        {
            polozky = veta.Split(' ');
        }
    }
}