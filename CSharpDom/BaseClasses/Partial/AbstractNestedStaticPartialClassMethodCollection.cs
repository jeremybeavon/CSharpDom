using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractNestedStaticPartialClassMethodCollection<
        TMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        AbstractNestedStaticClassMethodCollection<TMethod>,
        INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IStaticClassMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public override int Count
        {
            get { return Methods.Count; }
        }

        public abstract IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }

        public abstract IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementions { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStaticPartialClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStaticPartialClassMethodCollectionChildren(this, visitor);
        }
    }
}
