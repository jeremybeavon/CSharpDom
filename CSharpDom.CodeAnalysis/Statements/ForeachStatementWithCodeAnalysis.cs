using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForeachStatementWithCodeAnalysis :
        EditableForeachStatement<ITypeReferenceWithCodeAnalysis, IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<ForEachStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> node;
        private readonly CachedExpressionNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> iterator;
        private readonly CachedStatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> statement;
        private readonly CachedTypeReferenceNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> type;

        public ForeachStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax>(this);
            iterator = new CachedExpressionNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            statement = new CachedStatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
            type = new CachedTypeReferenceNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax),
                (parent, childSyntax) => null,
                null);
        }

        public override IExpressionWithCodeAnalysis Iterator
        {
            get { return iterator.Value; }
            set { iterator.Value = value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public ForEachStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        public override string VariableName
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ForEachStatementSyntax)value; }
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            node.SetStatementParentNode<TParentNode, TParentSyntax>(parent, getCollection);
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, StatementSyntax> getChildSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
        {
            node.SetStatementParentNode(parent, getChildSyntax, createChildSyntax);
        }
    }
}
