using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableEmptyStatement : AbstractStatement, IEmptyStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
