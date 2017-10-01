using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        AbstractGenericVisitableObject,
        IDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TMethodBody Body { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDestructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDestructor(this, visitor);
        }
    }
}
