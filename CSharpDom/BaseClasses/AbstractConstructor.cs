using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        AbstractGenericVisitableObject,
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TMethodBody Body { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorChildren(this, visitor);
        }
    }
}
