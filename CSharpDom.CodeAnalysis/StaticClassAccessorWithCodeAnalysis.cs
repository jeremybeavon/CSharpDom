using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassAccessorWithCodeAnalysis :
        AbstractStaticClassAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
        //IVisitable<IReflectionVisitor>,
    {
        private readonly AccessorWithCodeAnalysis accessor;
        private readonly StaticClassAccessorVisibilityModifier visibility;
        
        internal StaticClassAccessorWithCodeAnalysis(IHasStaticClassMemberVisibilityModifier parentVisibility, AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
            StaticClassMemberVisibilityModifier staticClassVisibility = accessor.MethodDefinition.StaticClassVisibility();
            if (parentVisibility.Visibility == staticClassVisibility)
            {
                visibility = StaticClassAccessorVisibilityModifier.None;
            }
            else
            {
                switch (staticClassVisibility)
                {
                    case StaticClassMemberVisibilityModifier.Internal:
                        visibility = StaticClassAccessorVisibilityModifier.Internal;
                        break;
                    case StaticClassMemberVisibilityModifier.Private:
                        visibility = StaticClassAccessorVisibilityModifier.Private;
                        break;
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override StaticClassAccessorVisibilityModifier Visibility
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
