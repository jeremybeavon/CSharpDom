using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        AbstractConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorChildren(this, visitor);
        }
    }
}
