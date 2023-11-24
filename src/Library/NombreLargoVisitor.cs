using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NombreLargoVisitor : IVisitor <Persona>
    {
        public string NombreLargo { get; private set; } = "";

        public void Visit (IVisitable <Persona> visitable)
        {
            var node = visitable as Node<Persona>;

            if (node.elemento.Nombre.Length > NombreLargo.Length)
            {
                NombreLargo = node.elemento.Nombre;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}