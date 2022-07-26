using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ödev
{
    public static class ExtensionMethod
    {
        //*//string ifadenin ilk iki karakterini yazdıran extensions method.
        //*//ismi ile ulaşmak için public static olmalıdır. 
        public static string GetFirstTwoCharacters(this String str) //*// this extension method olduğunu gösterir. string ifadesi ile metodun hangi sınıflar üzerinde geçerli olacağı belirtilir.
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 2); //*//substring, string tipli değişkenin belli bir kısmının alınmasunu geri kalan kısmının atılmasını sağlar.
            }
        }
    }
}
