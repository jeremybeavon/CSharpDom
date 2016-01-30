using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class EmptyStatementFactory : AbstractStatementFactory<IEmptyStatement, EmptyStatement>
    {
        public EmptyStatementFactory(IEmptyStatement statement)
            : base(statement)
        {
        }

        public override void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Value = new EmptyStatement();
        }
    }
}
