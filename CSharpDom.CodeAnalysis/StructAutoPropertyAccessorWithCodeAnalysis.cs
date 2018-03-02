using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructAutoPropertyAccessorWithCodeAnalysis :
        EditableStructAutoPropertyAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AutoPropertyAccessorWithCodeAnalysis accessor;
        
        internal StructAutoPropertyAccessorWithCodeAnalysis(AutoPropertyAccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
        }

        public AutoPropertyAccessorWithCodeAnalysis Accessor
        {
            get { return accessor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
            set { accessor.Attributes = value; }
        }
        
        public override StructAccessorVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructAccessorVisibilityModifier(); }
            set
            {
                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructAccessorVisibilityModifier(value));
            }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
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
