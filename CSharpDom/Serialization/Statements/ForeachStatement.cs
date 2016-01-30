using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ForeachStatement :
        IForeachStatement<TypeReference, Expression, Statement>
    {
        public Expression Iterator { get; set; }

        public Statement Statement { get; set; }

        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForeachStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForeachStatementChildren(this, visitor);
        }
    }
}
