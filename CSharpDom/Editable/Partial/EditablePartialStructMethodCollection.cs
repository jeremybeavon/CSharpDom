﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditablePartialStructMethodCollection<
        TMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        EditableStructMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IStructMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
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
            visitor.VisitPartialStructMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialStructMethodCollectionChildren(this, visitor);
        }
    }
}
