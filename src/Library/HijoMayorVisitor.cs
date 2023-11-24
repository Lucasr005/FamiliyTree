using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class HijoMayorVisitor : IVisitor<Persona>
    {
        public int HijoMayor { get; private set; }
        public void Visit(IVisitable<Persona> visitable)
        {
            var node = visitable as Node<Persona>;

            foreach (var hijo in node.Children)
            {
                if (hijo.elemento.Edad > HijoMayor)
                {
                    HijoMayor = hijo.elemento.Edad;
                }
                hijo.Accept(this);
            }
        }
    }
}