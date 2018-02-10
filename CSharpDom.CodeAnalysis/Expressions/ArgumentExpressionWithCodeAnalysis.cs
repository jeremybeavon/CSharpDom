using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal sealed class ArgumentExpressionWithCodeAnalysis :
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly Node<ArgumentExpressionWithCodeAnalysis, ArgumentSyntax> node;
        private readonly CachedExpressionNode<ArgumentExpressionWithCodeAnalysis, ArgumentSyntax> expression;

        public ArgumentExpressionWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Expression = expression;
        }

        internal ArgumentExpressionWithCodeAnalysis()
        {
            node = new Node<ArgumentExpressionWithCodeAnalysis, ArgumentSyntax>(this);
            expression = new CachedExpressionNode<ArgumentExpressionWithCodeAnalysis, ArgumentSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public INode<ArgumentSyntax> Node
        {
            get { return node; }
        }

        public ArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
    }
}
