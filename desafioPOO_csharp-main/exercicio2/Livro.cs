using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio2;

namespace exercicio2
{
    public class Livro
    {
        public string? Nome { get; set; }

        public List<Autor> autores = new List<Autor>();
    }
}