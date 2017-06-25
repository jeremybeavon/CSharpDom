using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractStaticPartialClassMethodCollection<
        TMethod,
        TExtensionMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        AbstractStaticClassMethodCollection<TMethod, TExtensionMethod>,
        IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public abstract IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }

        public abstract IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementions { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticPartialClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassMethodCollectionChildren(this, visitor);
        }
    }
}
