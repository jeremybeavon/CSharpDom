using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassAccessorWithCodeAnalysis :
        EditableClassAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithBodyWithCodeAnalysis accessor;
        
        internal ClassAccessorWithCodeAnalysis(AccessorWithBodyWithCodeAnalysis accessor)
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

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return accessor.Body; }
            set { accessor.Body = value; }
        }

        public override ClassAccessorVisibilityModifier Visibility
        {
            get
            {
                switch (Syntax.Modifiers.ToClassMemberVisibilityModifier())
                {
                    case ClassMemberVisibilityModifier.Internal:
                        return ClassAccessorVisibilityModifier.Internal;
                    case ClassMemberVisibilityModifier.ProtectedInternal:
                        return ClassAccessorVisibilityModifier.ProtectedInternal;
                    case ClassMemberVisibilityModifier.Protected:
                        return ClassAccessorVisibilityModifier.Protected;
                    case ClassMemberVisibilityModifier.Private:
                        return ClassAccessorVisibilityModifier.Private;
                }

                return ClassAccessorVisibilityModifier.None;
            }
            set
            {
                ClassMemberVisibilityModifier modifier = ClassMemberVisibilityModifier.None;
                switch (value)
                {
                    case ClassAccessorVisibilityModifier.Internal:
                        modifier = ClassMemberVisibilityModifier.Internal;
                        break;
                    case ClassAccessorVisibilityModifier.ProtectedInternal:
                        modifier = ClassMemberVisibilityModifier.ProtectedInternal;
                        break;
                    case ClassAccessorVisibilityModifier.Protected:
                        modifier = ClassMemberVisibilityModifier.Protected;
                        break;
                    case ClassAccessorVisibilityModifier.Private:
                        modifier = ClassMemberVisibilityModifier.Private;
                        break;
                }

                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(modifier));
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
