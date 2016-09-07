using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        AbstractDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public abstract TDeclaringType DeclaringType { get; }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedDelegate(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDelegateChildren(this, visitor);
        }
    }
}
