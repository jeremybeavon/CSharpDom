using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableGotoStatement : IEditableStatement, IGotoStatement
    {
        new string LabelName { get; set; }
    }
}