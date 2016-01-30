using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class StatementFactory : AbstractStatementFactory<IStatement, Statement>
    {
        public StatementFactory(IStatement statement)
            : base(statement)
        {
        }
    }
}
