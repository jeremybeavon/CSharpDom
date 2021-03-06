﻿using System;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForeachStatementWithCodeAnalysis :
        EditableForeachStatement<ITypeReferenceWithCodeAnalysis, IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<ForEachStatementSyntax>,
        IHasNode<ForEachStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> node;
        private readonly CachedExpressionNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> iterator;
        private readonly CachedStatementNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> statement;
        private readonly CachedTypeReferenceNode<ForeachStatementWithCodeAnalysis, ForEachStatementSyntax> type;

        public ForeachStatementWithCodeAnalysis(
            ITypeReferenceWithCodeAnalysis type,
            string variableName,
            IExpressionWithCodeAnalysis iterator,
            IStatementWithCodeAnalysis statement)
            : this()
        {
            Syntax = SyntaxFactory.ForEachStatement(
                type.Syntax,
                SyntaxFactory.Identifier(variableName),
                iterator.Syntax,
                statement.Syntax);
        }

        internal ForeachStatementWithCodeAnalysis()
        {
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
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
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
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ForEachStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<ForEachStatementSyntax> IHasNode<ForEachStatementSyntax>.Node => node;
    }
}
