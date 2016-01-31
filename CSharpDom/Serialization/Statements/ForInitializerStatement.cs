using System;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ForInitializerStatement : IForInitializerStatement
    {
        [DefaultValue(null)]
        public EmptyStatement EmptyStatement { get; set; }

        [DefaultValue(null)]
        public ExpressionStatement ExpressionStatement { get; set; }

        [DefaultValue(null)]
        public VariableDeclarationStatement VariableDeclarationStatement { get; set; }

        private IEnumerable<IForInitializerStatement> Statements
        {
            get
            {
                yield return EmptyStatement;
                yield return ExpressionStatement;
                yield return VariableDeclarationStatement;
            }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            IForInitializerStatement statement = Statements.FirstOrDefault(current => current != null);
            if (statement != null)
            {
                statement.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            IForInitializerStatement statement = Statements.FirstOrDefault(current => current != null);
            if (statement != null)
            {
                statement.Accept(visitor);
            }
        }
    }
}
