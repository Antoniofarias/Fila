using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fila - Primeira que entra é a primeira que sai

            Queue<string> minhafila = new Queue<string>();

            minhafila.Enqueue("Primeira");
            minhafila.Enqueue("Segunda");
            minhafila.Enqueue("Terceira");
            minhafila.Enqueue("Quarta");
            minhafila.Enqueue("Quinta");

            foreach (string elemento in minhafila)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();
        }
    }
}
// Console.WriteLine("O primeiro elemento da fila é: " + minhaFila.Peek()); Peek() retorna o primeiro elemento

// minhaFila.Dequeue(); Remove o primeiro elemento da fila