using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        EditableNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedDelegate(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedDelegateChildren(this, visitor);
        }
    }
}
