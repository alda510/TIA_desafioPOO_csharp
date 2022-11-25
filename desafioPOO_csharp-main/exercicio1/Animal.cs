using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Animal
    {
        public string? Raca { get; set; }
        public string? Tamanho { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som generico de animal");
        }
    }
}