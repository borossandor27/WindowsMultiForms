using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForms
{
    internal static class Program
    {
        public static FormNyito formNyito; // deklaráltuk a formNyito változót
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formNyito = new FormNyito(); // inicializáltuk a formNyito változót = definiáltuk a formNyito objektumot
            Application.Run(formNyito);
        }
    }
}
