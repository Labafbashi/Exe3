using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WolfMan : Wolf, IPerson
{
    public void Talk()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n>>>>\t This is implemented from IPerson class \t<<<<");
        Console.WriteLine("Wolf sound look likes: a-oooooo or owooooo.\n");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}