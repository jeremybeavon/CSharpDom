using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableGotoCaseStatement : AbstractStatement, IGotoCaseStatement
    {
        public abstract string CaseName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
