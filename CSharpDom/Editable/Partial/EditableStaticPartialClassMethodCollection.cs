using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditableStaticPartialClassMethodCollection<
        TMethod,
        TExtensionMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        EditableStaticClassMethodCollection<TMethod, TExtensionMethod>,
        IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public abstract ICollection<TPartialMethodDefinition> PartialMethodDefinitions { get; set; }

        public abstract ICollection<TPartialMethodImplementation> PartialMethodImplementations { get; set; }

        IReadOnlyCollection<TPartialMethodDefinition> IHasPartialMethodDefinitions<TPartialMethodDefinition>.PartialMethodDefinitions =>
            new ReadOnlyCollectionWrapper<TPartialMethodDefinition>(PartialMethodDefinitions);

        IReadOnlyCollection<TPartialMethodImplementation> IHasPartialMethodImplementations<TPartialMethodImplementation>.PartialMethodImplementations =>
            new ReadOnlyCollectionWrapper<TPartialMethodImplementation>(PartialMethodImplementations);

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
