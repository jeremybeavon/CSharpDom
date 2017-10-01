using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        AbstractGenericVisitableObject,
        IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IOperatorParameter
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TMethodBody Body { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract ConversionOperatorType OperatorType { get; }

        public abstract TParameter Parameter { get; }
        
        public abstract IReadOnlyCollection<TAttributeGroup> ReturnAttributes { get; }

        public abstract TTypeReference ReturnType { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConversionOperator(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConversionOperatorChildren(this, visitor);
        }
    }
}
