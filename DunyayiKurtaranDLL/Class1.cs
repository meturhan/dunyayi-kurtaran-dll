using System;
using System.Collections.Generic;
using System.Text;

namespace DunyayiKurtaranDLL
{
    public class DLL
    {
        public void DunyayiKurtar(string KimKurtarsin)
        {
            if (KimKurtarsin == "Cuneyt Arkin")
            {
                Console.WriteLine("Dunya Kurtarildi..!");
            }
            else
            {
                Console.WriteLine("Birak Uleyn kizi..!");
            }
        }
    }
}
