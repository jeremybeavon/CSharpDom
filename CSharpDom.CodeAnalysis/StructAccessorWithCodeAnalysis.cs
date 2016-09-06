using CSharpDom.Editable;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructAccessorWithCodeAnalysis :
        EditableStructAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithBodyWithCodeAnalysis accessor;

        internal StructAccessorWithCodeAnalysis(AccessorWithBodyWithCodeAnalysis accessor)
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

        public override StructAccessorVisibilityModifier Visibility
        {
            get
            {
                switch (Syntax.Modifiers.ToClassMemberVisibilityModifier())
                {
                    case ClassMemberVisibilityModifier.Internal:
                        return StructAccessorVisibilityModifier.Internal;
                    case ClassMemberVisibilityModifier.None:
                        return StructAccessorVisibilityModifier.None;
                    case ClassMemberVisibilityModifier.Private:
                        return StructAccessorVisibilityModifier.Private;
                    default:
                        throw new NotSupportedException();
                }
            }
            set
            {
                ClassMemberVisibilityModifier modifier = ClassMemberVisibilityModifier.None;
                switch (value)
                {
                    case StructAccessorVisibilityModifier.Internal:
                        modifier = ClassMemberVisibilityModifier.Internal;
                        break;
                    case StructAccessorVisibilityModifier.Private:
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
