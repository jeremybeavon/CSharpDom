using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class RefArgumentWithCodeAnalysis :
        EditableOutArgument<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly ArgumentWithCodeAnalysis argument;

        public RefArgumentWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.Argument(null, SyntaxFactory.Token(SyntaxKind.RefKeyword), expression.Syntax);
        }

        internal RefArgumentWithCodeAnalysis()
        {
            argument = new ArgumentWithCodeAnalysis();
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return argument.Expression; }
            set { argument.Expression = value; }
        }

        public override string Name { get => argument.Name; set => argument.Name = value; }

        public ArgumentSyntax Syntax
        {
            get { return argument.Syntax; }
            set { argument.Syntax = value; }
        }
        
        INode<ArgumentSyntax> IHasNode<ArgumentSyntax>.Node
        {
            get { return argument.Node; }
        }
    }
}
