using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> :
        AbstractGenericVisitableObject,
        IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }
        
        public abstract string Name { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> ReturnAttributes { get; }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialMethodDefinition(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialMethodDefinitionChildren(this, visitor);
        }
    }
}
