using CSharpDom.CodeAnalysis.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class StatementSyntaxExtensions
    {
        private static readonly TypedFactory<IInternalStatement> factory = new TypedFactory<IInternalStatement>()
        {
            { typeof(BlockSyntax), () => new BlockStatementWithCodeAnalysis() },
            { typeof(BreakStatementSyntax), () => new BreakStatementWithCodeAnalysis() }
        };

        public static IInternalStatement ToInternalStatement(this StatementSyntax syntax)
        {
            return null;
        }
    }
}
