using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UsingDirectiveWithCodeAnalysis : EditableUsingDirective,
        IHasSyntax<UsingDirectiveSyntax>,
        IHasNode<UsingDirectiveSyntax>
    {
        private readonly Node<UsingDirectiveWithCodeAnalysis, UsingDirectiveSyntax> node;

        public UsingDirectiveWithCodeAnalysis(string name)
            : this()
        {
            Syntax = SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(name));
        }

        internal UsingDirectiveWithCodeAnalysis()
        {
            node = new Node<UsingDirectiveWithCodeAnalysis, UsingDirectiveSyntax>(this);
        }

        public override string Name
        {
            get { return Syntax.Name.ToString(); }
            set { Syntax = Syntax.WithName(SyntaxFactory.ParseName(value)); }
        }

        public UsingDirectiveSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<UsingDirectiveWithCodeAnalysis, UsingDirectiveSyntax> Node
        {
            get { return node; }
        }

        INode<UsingDirectiveSyntax> IHasNode<UsingDirectiveSyntax>.Node
        {
            get { return node; }
        }
    }
}
