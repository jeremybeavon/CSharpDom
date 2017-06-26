using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractAbstractPartialClassMethodCollection<
        TMethod,
        TAbstractMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        AbstractAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
        IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public override int Count
        {
            get { return base.Count + PartialMethodDefinitions.Count + PartialMethodImplementations.Count; }
        }

        public abstract IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }

        public abstract IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementations { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractPartialClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractPartialClassMethodCollectionChildren(this, visitor);
        }
    }
}
