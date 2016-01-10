using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string s;
            s = Clipboard.GetText();
            var words = s.Split(' ');
            List<string> l = new List<string>();

            foreach (var word in words)
            {
                var cl = word.Replace(",", " ").Replace(".", "").Replace(";", "").Replace(":", "");
                if (!l.Contains(cl)) //Проверяем есть ли элемент в массиве
                {
                    l.Add(cl);
                }
                if (l.Lenght > 1000) // Если элементов больше 1000 в массиве, то выходим
                {
                    break;
                }
            }
            l.Sort(StringComparer.CurrentCultureIgnoreCase);
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}