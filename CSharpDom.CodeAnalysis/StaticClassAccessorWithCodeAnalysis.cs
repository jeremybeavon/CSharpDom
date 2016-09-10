using CSharpDom.Editable;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassAccessorWithCodeAnalysis :
        EditableStaticClassAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
        //IVisitable<IReflectionVisitor>,
    {
        private readonly AccessorWithBodyWithCodeAnalysis accessor;
        
        internal StaticClassAccessorWithCodeAnalysis(AccessorWithBodyWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
        }

        public AccessorWithBodyWithCodeAnalysis Accessor
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
            get
            {
                switch (Syntax.Modifiers.ToClassMemberVisibilityModifier())
                {
                    case ClassMemberVisibilityModifier.Internal:
                        return StaticClassAccessorVisibilityModifier.Internal;
                    case ClassMemberVisibilityModifier.None:
                        return StaticClassAccessorVisibilityModifier.None;
                    case ClassMemberVisibilityModifier.Private:
                        return StaticClassAccessorVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
            set
            {
                ClassMemberVisibilityModifier modifier = ClassMemberVisibilityModifier.None;
                switch (value)
                {
                    case StaticClassAccessorVisibilityModifier.Internal:
                        modifier = ClassMemberVisibilityModifier.Internal;
                        break;
                    case StaticClassAccessorVisibilityModifier.Private:
                        modifier = ClassMemberVisibilityModifier.Private;
                        break;
                }

                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(modifier));
            }
        }
        
        public override MethodBodyWithCodeAnalysis Body
        {
            get { return accessor.Body; }
            set { accessor.Body = value; }
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
