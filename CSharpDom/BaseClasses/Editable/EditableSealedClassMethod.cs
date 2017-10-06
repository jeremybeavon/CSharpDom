using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassMethodChildren(this, visitor);
        }
    }
}
