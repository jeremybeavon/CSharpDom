using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructConstructorWithCodeAnalysis :
        EditableStructConstructor<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasNode<ConstructorDeclarationSyntax>
    {
        private readonly ConstructorWithCodeAnalysis constructor;

        public StructConstructorWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name,
            IEnumerable<ConstructorParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this()
        {
            Syntax = SyntaxFactory.ConstructorDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility),
                SyntaxFactory.Identifier(name),
                SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters.Select(parameter => parameter.Syntax))),
                null,
                body.Syntax);
        }

        internal StructConstructorWithCodeAnalysis()
        {
            constructor = new ConstructorWithCodeAnalysis();
        }
        
        public ConstructorWithCodeAnalysis Constructor
        {
            get { return constructor; }
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? constructor.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                ConstructorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }
        
        INode<ConstructorDeclarationSyntax> IHasNode<ConstructorDeclarationSyntax>.Node
        {
            get { return constructor.Node; }
        }

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
