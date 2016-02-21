using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassMethodCollection<TMethod, TExtensionMethod> :
        IStaticClassMethodCollection<TMethod, TExtensionMethod>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
    {
        public int Count
        {
            get { return Methods.Count + ExtensionMethods.Count; }
        }

        public abstract IReadOnlyCollection<TExtensionMethod> ExtensionMethods { get; }

        protected abstract IReadOnlyCollection<TMethod> Methods { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<TMethod> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
