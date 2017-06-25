using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract TMethodBody Body { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> ReturnAttributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialMethodImplementation(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialMethodImplementationChildren(this, visitor);
        }
    }
}
