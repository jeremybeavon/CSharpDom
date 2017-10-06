using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableContinueStatement : AbstractStatement, IContinueStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitContinueStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
