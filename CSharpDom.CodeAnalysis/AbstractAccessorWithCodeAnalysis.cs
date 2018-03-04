using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractAccessorWithCodeAnalysis :
        EditableAbstractAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private AccessorWithCodeAnalysis accessor;

        public AbstractAccessorWithCodeAnalysis(AccessorType type)
            : this(new AccessorWithCodeAnalysis(type))
        {
        }

        internal AbstractAccessorWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
        }

        public AccessorWithCodeAnalysis Accessor
        {
            get { return accessor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
            set { accessor.Attributes = value; }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
        }

        public override AbstractAccessorVisibilityModifier Visibility
        {
            get
            {
                switch (Syntax.Modifiers.ToClassAccessorVisibilityModifier())
                {
                    case ClassAccessorVisibilityModifier.Internal:
                        return AbstractAccessorVisibilityModifier.Internal;
                    case ClassAccessorVisibilityModifier.ProtectedInternal:
                        return AbstractAccessorVisibilityModifier.ProtectedInternal;
                    case ClassAccessorVisibilityModifier.Protected:
                        return AbstractAccessorVisibilityModifier.Protected;
                    default:
                        return AbstractAccessorVisibilityModifier.None;
                }
            }
            set
            {
                ClassAccessorVisibilityModifier modifier = ClassAccessorVisibilityModifier.None;
                switch (value)
                {
                    case AbstractAccessorVisibilityModifier.Internal:
                        modifier = ClassAccessorVisibilityModifier.Internal;
                        break;
                    case AbstractAccessorVisibilityModifier.ProtectedInternal:
                        modifier = ClassAccessorVisibilityModifier.ProtectedInternal;
                        break;
                    case AbstractAccessorVisibilityModifier.Protected:
                        modifier = ClassAccessorVisibilityModifier.Protected;
                        break;
                }

                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassAccessorVisibilityModifier(modifier));
            }
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
