using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract TTypeReference ReturnType { get; }
        
        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDelegateChildren(this, visitor);
        }
    }
}
