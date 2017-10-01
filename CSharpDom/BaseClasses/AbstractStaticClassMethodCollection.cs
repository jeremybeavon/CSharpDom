using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassMethodCollection<TMethod, TExtensionMethod> :
        AbstractGenericVisitableObject,
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<TMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        } 

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
