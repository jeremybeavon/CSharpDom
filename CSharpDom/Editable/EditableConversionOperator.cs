using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IOperatorParameter
        where TMethodBody : IMethodBody
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual ConversionOperatorType OperatorType { get; set; }

        public virtual TParameter Parameter { get; set; }
        
        public virtual IReadOnlyCollection<TAttributeGroup> ReturnAttributes { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConversionOperator(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConversionOperatorChildren(this, visitor);
        }
    }
}
