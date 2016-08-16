using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedDelegate(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDelegateChildren(this, visitor);
        }
    }
}
