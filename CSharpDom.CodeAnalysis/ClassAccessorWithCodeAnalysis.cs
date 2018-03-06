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
        
        public ClassAccessorWithCodeAnalysis(AccessorType accessorType, MethodBodyWithCodeAnalysis body)
            : this(new AccessorWithBodyWithCodeAnalysis(accessorType, body))
        {
        }

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
            get { return Syntax.Modifiers.ToClassAccessorVisibilityModifier(); }
            set
            {
                AccessorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassAccessorVisibilityModifier(value));
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
