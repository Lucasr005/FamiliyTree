using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;



namespace Library
{
    public interface IVisitor<T>
    {
        public void Visit(IVisitable<T> visitable);
    }
}