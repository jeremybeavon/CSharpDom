using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract OperatorOverloadType OperatorType { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract TTypeReference ReturnType { get; }

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
