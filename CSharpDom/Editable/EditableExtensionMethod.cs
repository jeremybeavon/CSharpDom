using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableExtensionMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TExtensionParameter,
        TParameter,
        TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticClass
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TExtensionParameter : IExtensionParameter
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public virtual TExtensionParameter ExtensionParameter { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExtensionMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExtensionMethodChildren(this, visitor);
        }
    }
}
