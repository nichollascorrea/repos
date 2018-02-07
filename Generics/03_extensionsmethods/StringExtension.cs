using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_extensionsmethods
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            string Primeira = str.Substring(0, 1);
            //Primeira.ToUpper();

            string Segunda = str.Substring(1);

            return Primeira.ToUpper() + Segunda;

        }
    }
}
