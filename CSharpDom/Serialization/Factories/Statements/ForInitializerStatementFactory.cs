using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ForInitializerStatementFactory : AbstractStatementFactory<IForInitializerStatement, ForInitializerStatement>
    {
        public ForInitializerStatementFactory(IForInitializerStatement statement)
            : base(statement)
        {
        }
    }
}
