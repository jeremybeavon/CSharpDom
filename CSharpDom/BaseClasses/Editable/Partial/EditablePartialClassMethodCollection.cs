﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.BaseClasses.Editable.Partial
{
    public abstract class EditablePartialClassMethodCollection<
        TMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        EditableClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IClassMethod
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
            visitor.VisitClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassMethodCollectionChildren(this, visitor);
        }
    }
}
