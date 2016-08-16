using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IOperatorParameter
        where TMethodBody : IMethodBody
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual OperatorOverloadType OperatorType { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitOperatorOverload(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitOperatorOverloadChildren(this, visitor);
        }
    }
}
