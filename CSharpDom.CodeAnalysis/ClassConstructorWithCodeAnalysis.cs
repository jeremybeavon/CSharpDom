using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassConstructorWithCodeAnalysis :
        EditableClassConstructor<
            AttributeGroupWithCodeAnalysis,
            IClassType,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly ConstructorWithCodeAnalysis constructor;

        internal ClassConstructorWithCodeAnalysis(IClassType declaringType)
        {
            base.DeclaringType = declaringType;
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constructor.Attributes; }
            set { constructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return constructor.Body; }
            set { constructor.Body = value; }
        }
        
        public override IClassType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ConstructorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }
    }
}
