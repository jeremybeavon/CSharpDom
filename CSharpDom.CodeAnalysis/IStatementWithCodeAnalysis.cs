using CSharpDom.Common.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IStatementWithCodeAnalysis : IEditableStatement, IHasSyntax<StatementSyntax>
    {
    }
}
