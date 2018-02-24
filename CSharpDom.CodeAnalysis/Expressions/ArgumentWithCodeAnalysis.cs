using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ArgumentWithCodeAnalysis :
        EditableArgument<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly Node<ArgumentWithCodeAnalysis, ArgumentSyntax> node;
        private readonly CachedExpressionNode<ArgumentWithCodeAnalysis, ArgumentSyntax> expression;

        public ArgumentWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Expression = expression;
        }

        internal ArgumentWithCodeAnalysis()
        {
            node = new Node<ArgumentWithCodeAnalysis, ArgumentSyntax>(this);
            expression = new CachedExpressionNode<ArgumentWithCodeAnalysis, ArgumentSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override string Name
        {
            get => Syntax.NameColon?.Name.Identifier.Text;
            set => Syntax = Syntax.WithNameColon(SyntaxFactory.NameColon(value));
        }

        public ArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal INode<ArgumentSyntax> Node => node;

        INode<ArgumentSyntax> IHasNode<ArgumentSyntax>.Node => node;
    }
}
