using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructAccessorWithCodeAnalysis :
        AbstractStructAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly StructAccessorVisibilityModifier visibility;
        private readonly AccessorWithCodeAnalysis accessor;

        internal StructAccessorWithCodeAnalysis(IHasStructMemberVisibilityModifier parentVisibility, AccessorWithCodeAnalysis accessor)
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

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
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

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
