using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class GenericMemberExpressionWithCodeAnalysis :
        EditableGenericMemberExpression<IExpressionWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<MemberAccessExpressionSyntax>,
        IHasNode<MemberAccessExpressionSyntax>,
        IInternalGenericExpression
    {
        private readonly GenericExpressionNode<
            GenericMemberExpressionWithCodeAnalysis,
            MemberAccessExpressionSyntax> node;
        private readonly CachedExpressionNode<
            GenericMemberExpressionWithCodeAnalysis,
            MemberAccessExpressionSyntax> objectExpression;
        private readonly GenericParameterList<
            GenericMemberExpressionWithCodeAnalysis,
            MemberAccessExpressionSyntax> genericParameters;

        public GenericMemberExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis objectExpression,
            string memberName,
            IEnumerable<ITypeReferenceWithCodeAnalysis> genericParameters)
            : this()
        {
            SeparatedSyntaxList<TypeSyntax> argumentList = SyntaxFactory.SeparatedList(
                genericParameters.Select(parameter => parameter.Syntax));
            GenericNameSyntax name = SyntaxFactory.GenericName(
                SyntaxFactory.Identifier(memberName),
                SyntaxFactory.TypeArgumentList(argumentList));
            Syntax = SyntaxFactory.MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                objectExpression.Syntax,
                name);
        }

        public GenericMemberExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis objectExpression,
            string memberName,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
            : this(objectExpression, memberName, (IEnumerable<ITypeReferenceWithCodeAnalysis>)genericParameters)
        {
        }

        internal GenericMemberExpressionWithCodeAnalysis()
        {
            node = new GenericExpressionNode<GenericMemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax>(this);
            objectExpression = new CachedExpressionNode<GenericMemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            genericParameters = new GenericParameterList<GenericMemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax>(
                node,
                syntax => syntax.Name,
                (parentSyntax, childSyntax) => parentSyntax.WithName((SimpleNameSyntax)childSyntax));
        }

        public override string MemberName
        {
            get { return Syntax.Name.Identifier.Text; }
            set
            {
                MemberAccessExpressionSyntax syntax = Syntax;
                Syntax = syntax.WithName((SimpleNameSyntax)syntax.Name.WithName(value));
            }
        }

        public override IExpressionWithCodeAnalysis ObjectExpression
        {
            get { return objectExpression.Value; }
            set { objectExpression.Value = value; }
        }

        public MemberAccessExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get => genericParameters;
            set => genericParameters.ReplaceList(value);
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<MemberAccessExpressionSyntax> IHasNode<MemberAccessExpressionSyntax>.Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (MemberAccessExpressionSyntax)value; }
        }
    }
}
