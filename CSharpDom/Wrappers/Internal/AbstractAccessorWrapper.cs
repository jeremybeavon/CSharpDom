﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractAccessorWrapper : AbstractWrapper<IAbstractAccessor>, IAbstractAccessorWrapper
    {
        private Func<IReadOnlyCollection<IAttributeGroupWrapper>> attributes;
        private Func<AbstractAccessorVisibilityModifier> visibility;

        public AbstractAccessorWrapper(IAbstractAccessor accessor)
            : base(accessor)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get { return attributes(); }
        }

        public AbstractAccessorVisibilityModifier Visibility => visibility();

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractAccessorChildren(this, visitor);
        }

        public override void VisitAbstractAccessor<TAttributeGroup>(
            IAbstractAccessor<TAttributeGroup> accessor)
        {
            attributes = accessor.Attributes.WrapAttributes();
            visibility = () => accessor.Visibility;
        }
    }
}
