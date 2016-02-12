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

        protected void VisitChildren(params object[] children)
        {
            foreach (object child in children)
            {
                IVisitable<IGenericVisitor> item = child as IVisitable<IGenericVisitor>;
                if (item != null)
                {
                    item.Accept(this);
                }
                else
                {
                    IEnumerable<IVisitable<IGenericVisitor>> collection = child as IEnumerable<IVisitable<IGenericVisitor>>;
                    if (collection != null)
                    {
                        foreach (IVisitable<IGenericVisitor> childItem in collection)
                        {
                            childItem.Accept(this);
                        }
                    }
                }

                if (Result != null)
                {
                    return;
                }
            }
        }
    }
}
