using CSharpDom.Common.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IStatementWithCodeAnalysis : IStatement, IHasSyntax<StatementSyntax>
    {
    }
}
