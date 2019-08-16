using System;
using System.Windows.Forms;

namespace AbsolutePathFinder
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Programm wird gestartet...\n");
            Console.WriteLine("Folgende(r) Pfade(e) wurde(n) erkannt und in die Zwischenablage kopiert:\n");
            Console.WriteLine(GetAbsoluteFilename(args) + "\n");
            Console.WriteLine("Enter drücken zum Beenden!");
            Console.ReadLine();
        }

        static String GetAbsoluteFilename(string[] args)
        {
            string temp = "";

            foreach (var item in args)
            {
                temp += item;
            }

            Clipboard.SetText(temp);
            return temp;
        }
    }
}
