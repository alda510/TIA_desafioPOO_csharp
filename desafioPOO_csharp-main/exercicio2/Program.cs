using System.Collections.Generic;
using exercicio2;

Autor a = new Autor();
a.Nome = "Giovanni";

Livro l = new Livro();
l.autores.Add(a);

Console.WriteLine(l.autores[0].Nome);