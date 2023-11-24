using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class EdadSumarVisitor : IVisitor <Persona>
    {
        public int sumadorEdades = 0;

        public void Visit(IVisitable<Persona> visitable)
        {
            var node = visitable as Node <Persona>;
            
            if (node!=null)
            {
                this.sumadorEdades += node.Edad();
                foreach (Node<Persona> hijo in node.Children)
                {
                    hijo.Accept(this);
                }
            }
        }
    }
}