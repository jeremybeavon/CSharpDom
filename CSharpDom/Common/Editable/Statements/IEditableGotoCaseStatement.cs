using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableGotoCaseStatement : IEditableStatement, IGotoCaseStatement
    {
        new string CaseName { get; set; }
    }
}