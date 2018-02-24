using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NewExpressionWithCodeAnalysis :
        EditableNewExpression<ITypeReferenceWithCodeAnalysis, IArgumentWithCodeAnalysis>,
        IHasSyntax<ObjectCreationExpressionSyntax>,
        IHasNode<ObjectCreationExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> node;
        private readonly ArgumentListWrapper<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> parameters;
        private readonly CachedTypeReferenceNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax> type;

        public NewExpressionWithCodeAnalysis(
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IExpressionWithCodeAnalysis> parameters)
            : this()
        {
            Syntax = SyntaxFactory.ObjectCreationExpression(type.Syntax, parameters.ToArgumentList(), null);
        }

        internal NewExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(this);
            parameters = new ArgumentListWrapper<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(
                node,
                syntax => syntax.ArgumentList,
                (parentSyntax, childSyntax) => parentSyntax.WithArgumentList(childSyntax));
            type = new CachedTypeReferenceNode<NewExpressionWithCodeAnalysis, ObjectCreationExpressionSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override IList<IArgumentWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set { parameters.ReplaceList(value); }
        }

        public ObjectCreationExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<ObjectCreationExpressionSyntax> IHasNode<ObjectCreationExpressionSyntax>.Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ObjectCreationExpressionSyntax)value; }
        }
    }
}
