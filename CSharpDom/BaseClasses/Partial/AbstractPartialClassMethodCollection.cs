﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractPartialClassMethodCollection<
        TMethod,
        TExplicitInterfaceMethod,
        TPartialMethodDefinition,
        TPartialMethodImplementation> :
        AbstractClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
        public abstract IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }

        public abstract IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementations { get; }

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
