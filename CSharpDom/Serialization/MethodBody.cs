using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Statements;
using CSharpDom.Serialization.IL;

namespace CSharpDom.Serialization
{
    public sealed class MethodBody : IMethodBody<Statement>
    {
        public MethodBody()
        {
            Instructions = new List<ILInstruction>();
            Statements = new List<Statement>();
        }

        public List<ILInstruction> Instructions { get; set; }

        public List<Statement> Statements { get; set; }

        IReadOnlyList<Statement> IMethodBody<Statement>.Statements
        {
            get { return Statements; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
