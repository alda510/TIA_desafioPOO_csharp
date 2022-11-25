using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Passaro: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Bem-te-vi");
        }
    }
}