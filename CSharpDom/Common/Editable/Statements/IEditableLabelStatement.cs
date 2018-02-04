using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableLabelStatement : IEditableStatement, ILabelStatement
    {
        new string LabelName { get; set; }
    }
}