﻿using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractDelegateReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IDelegateReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyList<TTypeReference> GenericParameters { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }
    }
}
