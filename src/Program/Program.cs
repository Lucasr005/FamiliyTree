using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Persona> abuelo = new Node<Persona> (new Persona("Oscar", 80));
            Node<Persona> abuela = new Node<Persona> (new Persona("Bety", 79));
            Node<Persona> padre = new Node<Persona> (new Persona("Miguel", 56));
            Node<Persona> madre = new Node<Persona> (new Persona("Jacqueline", 55));
            Node<Persona> hijo = new Node<Persona> (new Persona("Lucas", 18));

            abuelo.AddChildren(madre);
            abuela.AddChildren(madre);

            madre.AddChildren(hijo);
            padre.AddChildren(hijo);

            EdadSumarVisitor edadSumarVisitor = new EdadSumarVisitor();
            abuelo.Accept(edadSumarVisitor);
            Console.WriteLine($"La suma de las edades es: {edadSumarVisitor.sumadorEdades}");

            HijoMayorVisitor hijoMayorVisitor = new HijoMayorVisitor();
            padre.Accept(hijoMayorVisitor);
            Console.WriteLine($"La edad de el hijo mayor es: {hijoMayorVisitor.HijoMayor}");

            NombreLargoVisitor nombreLargoVisitor = new NombreLargoVisitor();
            madre.Accept(nombreLargoVisitor);
            Console.WriteLine($"El nombre mas largo es: {nombreLargoVisitor.NombreLargo}");

        }
    }
}
