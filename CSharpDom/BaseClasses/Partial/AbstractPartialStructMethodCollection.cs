using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractPartialStructMethodCollection<
        TMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        AbstractStructMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IStructMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public abstract IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }

        public abstract IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementions { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialStructMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialStructMethodCollectionChildren(this, visitor);
        }
    }
}
