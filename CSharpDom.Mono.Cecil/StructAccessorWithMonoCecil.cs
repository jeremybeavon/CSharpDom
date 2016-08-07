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
        private readonly StructAccessorVisibilityModifier visibility;
        private readonly AccessorWithMonoCecil accessor;

        internal StructAccessorWithMonoCecil(IHasStructMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
            StructMemberVisibilityModifier structVisibility = accessor.MethodDefinition.StructVisibility();
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

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StructAccessorVisibilityModifier Visibility
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
