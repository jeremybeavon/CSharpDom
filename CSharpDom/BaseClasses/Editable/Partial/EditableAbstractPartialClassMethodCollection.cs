﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.BaseClasses.Editable.Partial
{
    public abstract class EditableAbstractPartialClassMethodCollection<
        TMethod,
        TAbstractMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        EditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
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

        public abstract ICollection<TPartialMethodDefinition> PartialMethodDefinitions { get; set; }

        public abstract ICollection<TPartialMethodImplementation> PartialMethodImplementations { get; set; }

        IReadOnlyCollection<TPartialMethodDefinition> IHasPartialMethodDefinitions<TPartialMethodDefinition>.PartialMethodDefinitions =>
            new ReadOnlyCollectionWrapper<TPartialMethodDefinition>(PartialMethodDefinitions);

        IReadOnlyCollection<TPartialMethodImplementation> IHasPartialMethodImplementations<TPartialMethodImplementation>.PartialMethodImplementations =>
            new ReadOnlyCollectionWrapper<TPartialMethodImplementation>(PartialMethodImplementations);

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
