using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }
        
        public virtual string Name { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

        public virtual IReadOnlyCollection<TAttributeGroup> ReturnAttributes { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethod(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
