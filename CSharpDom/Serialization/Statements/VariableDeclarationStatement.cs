using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class VariableDeclarationStatement : IVariableDeclarationStatement<TypeReference, Expression>
    {
        public VariableDeclarationStatement()
        {
            Expressions = new List<Expression>();
        }

        public List<Expression> Expressions { get; set; }

        public TypeReference Type { get; set; }

        IReadOnlyList<Expression> IVariableDeclarationStatement<TypeReference, Expression>.Expressions
        {
            get { return Expressions; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
