using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassAutoPropertyAccessorWithCodeAnalysis :
        EditableStaticClassAutoPropertyAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AutoPropertyAccessorWithCodeAnalysis accessor;
        
        internal StaticClassAutoPropertyAccessorWithCodeAnalysis(AutoPropertyAccessorWithCodeAnalysis accessor)
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
        
        public override StaticClassAccessorVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassAccessorVisibilityModifier(); }
            set
            {
                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassAccessorVisibilityModifier(value));
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
