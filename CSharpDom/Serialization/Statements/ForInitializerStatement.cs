using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ForInitializerStatement : IForInitializerStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
