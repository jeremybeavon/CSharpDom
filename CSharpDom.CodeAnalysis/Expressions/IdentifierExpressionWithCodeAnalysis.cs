using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class IdentifierExpressionWithCodeAnalysis :
        EditableIdentifierExpression,
        IHasSyntax<IdentifierNameSyntax>,
        IHasNode<IdentifierNameSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<IdentifierExpressionWithCodeAnalysis, IdentifierNameSyntax> node;

        public IdentifierExpressionWithCodeAnalysis(string name)
            : this()
        {
            Syntax = SyntaxFactory.IdentifierName(name);
        }

        internal IdentifierExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<IdentifierExpressionWithCodeAnalysis, IdentifierNameSyntax>(this);
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public IdentifierNameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<IdentifierNameSyntax> IHasNode<IdentifierNameSyntax>.Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (IdentifierNameSyntax)value; }
        }
    }
}
