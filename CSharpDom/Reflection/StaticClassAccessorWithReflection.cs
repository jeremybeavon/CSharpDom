﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassAccessorWithReflection :
        AbstractStaticClassAccessor<AttributeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
        //IVisitable<IReflectionVisitor>,
    {
        private readonly AccessorWithReflection accessor;
        private readonly StaticClassMemberVisibilityModifier visibility;
        
        internal StaticClassAccessorWithReflection(IHasStaticClassMemberVisibilityModifier parentVisibility, AccessorWithReflection accessor)
        {
            this.accessor = accessor;
            visibility = accessor.MethodInfo.StaticClassVisibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = StaticClassMemberVisibilityModifier.None;
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
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
