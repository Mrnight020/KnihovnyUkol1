using System.Reflection.Emit;
using System.Text;

namespace RetezUtil
{
    public class Class1
    {
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

        public static string[] Zobraz(ref string veta,Label label)
        {
            string[] polozky = veta.Split(' ');
            return polozky;
        }
    }
}