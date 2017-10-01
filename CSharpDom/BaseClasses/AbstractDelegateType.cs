using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        AbstractGenericVisitableObject,
        IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }
        
        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract TTypeReference ReturnType { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateType(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateTypeChildren(this, visitor);
        }
    }
}
