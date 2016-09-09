using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IOperatorParameter
        where TMethodBody : IMethodBody
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TMethodBody Body { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract ConversionOperatorType OperatorType { get; set; }

        public abstract TParameter Parameter { get; set; }
        
        public abstract ICollection<TAttributeGroup> ReturnAttributes { get; set; }

        public abstract TTypeReference ReturnType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasReturnAttributes<TAttributeGroup>.ReturnAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(ReturnAttributes); }
        }

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
