using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public interface IVisitable<T>
    {
        public void Accept(IVisitor<T> visitor);
    }
}