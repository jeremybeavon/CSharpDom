using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class GotoCaseStatementFactory : AbstractStatementFactory<IGotoCaseStatement, GotoCaseStatement>
    {
        public GotoCaseStatementFactory(IGotoCaseStatement statement)
            : base(statement)
        {
        }

        public override void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement)
        {
            Value = new GotoCaseStatement()
            {
                CaseName = gotoCaseStatement.CaseName
            };
        }
    }
}
