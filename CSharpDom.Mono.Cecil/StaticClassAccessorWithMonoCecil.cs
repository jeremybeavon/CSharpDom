﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassAccessorWithMonoCecil :
        AbstractStaticClassAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
        //IVisitable<IReflectionVisitor>,
    {
        private readonly AccessorWithMonoCecil accessor;
        private readonly StaticClassMemberVisibilityModifier visibility;
        
        internal StaticClassAccessorWithMonoCecil(IHasStaticClassMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
            visibility = accessor.MethodDefinition.StaticClassVisibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = StaticClassMemberVisibilityModifier.None;
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return accessor.MethodDefinition; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
