using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        AbstractGenericVisitableObject,
        IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TMethodBody Body { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticConstructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticConstructorChildren(this, visitor);
        }
    }
}
