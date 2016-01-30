using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyForStatement :
        AbstractForStatement<ReadOnlyExpressionStatement, IForInitializerStatement, ReadOnlyStatement>
    {
        private readonly IForInitializerStatement initializer;
        private readonly ReadOnlyExpressionStatement condition;
        private readonly IReadOnlyCollection<ReadOnlyExpressionStatement> incrementExpressions;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyForStatement(ForStatement forStatement)
        {
            if (forStatement.InitialValueExpression != null)
            {
                initializer = new ReadOnlyExpressionStatement(forStatement.InitialValueExpression);
            }
            else if (forStatement.InitialValueStatement != null)
            {
                initializer = new ReadOnlyVariableDeclarationStatement(forStatement.InitialValueStatement);
            }

            condition = new ReadOnlyExpressionStatement(forStatement.Condition);
            incrementExpressions = new[] { new ReadOnlyExpressionStatement(forStatement.Increment) };
            statement = new ReadOnlyStatement(forStatement.Statement);
        }

        public override ReadOnlyExpressionStatement Condition
        {
            get { return condition; }
        }

        public override IReadOnlyCollection<ReadOnlyExpressionStatement> IncrementExpressions
        {
            get { return incrementExpressions; }
        }

        public override IForInitializerStatement InitialValueStatement
        {
            get { return initializer; }
        }

        public override ReadOnlyStatement Statement
        {
            get { return statement; }
        }
    }
}
