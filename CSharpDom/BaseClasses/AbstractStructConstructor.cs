using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        AbstractConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorChildren(this, visitor);
        }
    }
}
