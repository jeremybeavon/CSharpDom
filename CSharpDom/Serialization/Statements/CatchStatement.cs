using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class CatchStatement : ICatchStatement<TypeReference, Statement>
    {
        public CatchStatement()
        {
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; set; }

        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        IReadOnlyList<Statement> ICatchStatement<TypeReference, Statement>.Statements
        {
            get { return Statements; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitCatchStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitCatchStatementChildren(this, visitor);
        }
    }
}
