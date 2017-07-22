using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassStaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<
            AttributeGroupWithCodeAnalysis, 
            IClassTypeWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasNode<ConstructorDeclarationSyntax>
    {
        private readonly StaticConstructorWithCodeAnalysis staticConstructor;

        public ClassStaticConstructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this()
        {
            Syntax = SyntaxFactory.ConstructorDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.StaticKeyword)),
                SyntaxFactory.Identifier(name),
                SyntaxFactory.ParameterList(),
                null,
                body.Syntax);
        }

        internal ClassStaticConstructorWithCodeAnalysis()
        {
            staticConstructor = new StaticConstructorWithCodeAnalysis();
        }

        public StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return staticConstructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return staticConstructor.Attributes; }
            set { staticConstructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return staticConstructor.Body; }
            set { staticConstructor.Body = value; }
        }

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? staticConstructor.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return staticConstructor.Syntax; }
            set { staticConstructor.Syntax = value; }
        }
        
        INode<ConstructorDeclarationSyntax> IHasNode<ConstructorDeclarationSyntax>.Node
        {
            get { return staticConstructor.Node; }
        }

        internal Func<IClassTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
