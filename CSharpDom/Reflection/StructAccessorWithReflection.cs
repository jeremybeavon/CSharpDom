﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StructAccessorWithReflection :
        AbstractStructAccessor<AttributeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly StructAccessorVisibilityModifier visibility;
        private readonly AccessorWithReflection accessor;

        internal StructAccessorWithReflection(IHasStructMemberVisibilityModifier parentVisibility, AccessorWithReflection accessor)
        {
            this.accessor = accessor;
            StructMemberVisibilityModifier structVisibility = accessor.MethodInfo.StructVisibility();
            if (parentVisibility.Visibility == structVisibility)
            {
                visibility = StructAccessorVisibilityModifier.None;
            }
            else
            {
                switch (structVisibility)
                {
                    case StructMemberVisibilityModifier.Internal:
                        visibility = StructAccessorVisibilityModifier.Internal;
                        break;
                    case StructMemberVisibilityModifier.Private:
                        visibility = StructAccessorVisibilityModifier.Private;
                        break;
                }
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StructAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodInfo MethodInfo
        {
            get { return accessor.MethodInfo; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
