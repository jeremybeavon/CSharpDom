using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IClassReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyList<TTypeReference> GenericParameters { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }
    }
}
