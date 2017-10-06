using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using CSharpDom.Wrappers.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForStatementWithCodeAnalysis :
        EditableForStatement<IExpressionWithCodeAnalysis, IForInitializerStatementWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<ForStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax> node;
        private readonly CachedExpressionNode<ForStatementWithCodeAnalysis, ForStatementSyntax> condition;
        private readonly ExpressionListWrapper<ForStatementWithCodeAnalysis, ForStatementSyntax> incrementExpressions;
        private readonly CachedStatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax> statement;
        private readonly CachedChildNode<
            ForStatementWithCodeAnalysis,
            ForStatementSyntax,
            IInternalForStatementInitializer,
            VariableDeclarationSyntax> initialValueStatement;

        internal ForStatementWithCodeAnalysis()
        {
            node = new StatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax>(this);
            condition = new CachedExpressionNode<ForStatementWithCodeAnalysis, ForStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
            incrementExpressions = new ExpressionListWrapper<ForStatementWithCodeAnalysis, ForStatementSyntax>(
                node,
                syntax => syntax.Incrementors,
                (parentSyntax, childSyntax) => parentSyntax.WithIncrementors(childSyntax));
            statement = new CachedStatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
            initialValueStatement = new CachedChildNode<ForStatementWithCodeAnalysis, ForStatementSyntax, IInternalForStatementInitializer, VariableDeclarationSyntax>(
                node,
                () => null,
                syntax => syntax.Declaration,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override ICollection<IExpressionWithCodeAnalysis> IncrementExpressions
        {
            get { return incrementExpressions; }
            set { incrementExpressions.ReplaceList(value); }
        }

        public override IForInitializerStatementWithCodeAnalysis InitialValueStatement
        {
            get { return initialValueStatement.Value; }
            set { initialValueStatement.Value = (IInternalForStatementInitializer)value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public ForStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ForStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }
    }
}
