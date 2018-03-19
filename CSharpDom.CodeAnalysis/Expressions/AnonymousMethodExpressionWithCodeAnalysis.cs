using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AnonymousMethodExpressionWithCodeAnalysis :
        EditableAnonymousMethodExpression<AnonymousMethodParameterWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<AnonymousMethodExpressionSyntax>,
        IHasNode<AnonymousMethodExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax> node;
        private readonly StatementListWrapper<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax> statements;
        private readonly SeparatedSyntaxNodeList<
            AnonymousMethodExpressionWithCodeAnalysis,
            AnonymousMethodExpressionSyntax,
            AnonymousMethodParameterWithCodeAnalysis,
            ParameterSyntax> parameters;

        internal AnonymousMethodExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax>(this);
            parameters = new SeparatedSyntaxNodeList<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax, AnonymousMethodParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new AnonymousMethodParameterWithCodeAnalysis());
            statements = new StatementListWrapper<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax>(
                node,
                syntax => syntax.Block.Statements,
                (parentSyntax, childSyntax) => parentSyntax.WithBlock(parentSyntax.Block.WithStatements(childSyntax)));
        }

        public override bool IsAsync
        {
            get => Syntax.AsyncKeyword.Kind() == SyntaxKind.AsyncKeyword;
            set => Syntax = Syntax.WithAsyncKeyword(SyntaxFactory.Token(value ? SyntaxKind.AsyncKeyword : SyntaxKind.None));
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get => statements;
            set => statements.ReplaceList(value);
        }

        public override IList<AnonymousMethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set { parameters.ReplaceList(value); }
        }

        public AnonymousMethodExpressionSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (AnonymousMethodExpressionSyntax)value;
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;

        INode<AnonymousMethodExpressionSyntax> IHasNode<AnonymousMethodExpressionSyntax>.Node => node;
    }
}
