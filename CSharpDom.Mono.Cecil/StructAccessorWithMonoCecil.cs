using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructAccessorWithMonoCecil :
        AbstractStructAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly StructMemberVisibilityModifier visibility;
        private readonly AccessorWithMonoCecil accessor;

        internal StructAccessorWithMonoCecil(IHasStructMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
            visibility = accessor.MethodDefinition.StructVisibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = StructMemberVisibilityModifier.None;
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StructMemberVisibilityModifier Visibility
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
