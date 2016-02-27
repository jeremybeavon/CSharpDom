using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }
        
        public abstract string Name { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract TTypeReference ReturnType { get; }

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
