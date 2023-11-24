using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq.Expressions;

namespace Library
{
    public class Node <T> : IVisitable <T>
    {
        public T elemento;

        private List<Node <T>> children = new List<Node <T>>();

        public ReadOnlyCollection<Node <T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T elemento)
        {
            this.elemento = elemento;
        }

        public void AddChildren(Node <T> n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor <T> visitor)
        {
            visitor.Visit(this);
        }

        public int Edad()
        {
            if (this.elemento is Persona)
            {
                Persona person = (Persona)(object)this.elemento;
                return person.Edad;
            }
            else 
            {
                return 0;
            }
        }
    }
}