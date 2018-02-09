using CSharpDom.Common.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public interface IForInitializerStatementWithCodeAnalysis :
        IStatementWithCodeAnalysis,
        IEditableForInitializerStatement
    {
    }
}
