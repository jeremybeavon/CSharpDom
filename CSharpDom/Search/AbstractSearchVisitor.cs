using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Search
{
    public abstract class AbstractSearchVisitor<T> : AbstractGenericVisitor
    {
        public T Result { get; protected set; }

        protected void VisitChildren(params IEnumerable[] children)
        {
            foreach (IVisitable<IGenericVisitor> child in children
                .Cast<IEnumerable<IVisitable<IGenericVisitor>>>()
                .SelectMany(child => child))
            {
                if (Result != null)
                {
                    return;
                }

                child.Accept(this);
            }
        }
    }
}
