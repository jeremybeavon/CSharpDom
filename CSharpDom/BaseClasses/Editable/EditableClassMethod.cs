using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassMethodChildren(this, visitor);
        }
    }
}
