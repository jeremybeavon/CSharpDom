using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUnspecifiedTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IUnspecifiedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyList<TTypeReference> GenericParameters { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnspecifiedTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitUnspecifiedTypeReference(this, visitor);
        }
    }
}
