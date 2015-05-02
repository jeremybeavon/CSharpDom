using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class VariableDeclarationStatement : LinqExpressionMapping<Expression, LocalDeclarationStatementSyntax>
    {
        public VariableDeclarationStatement(IReadOnlyCollection<Expression> expressions, LocalDeclarationStatementSyntax syntax)
            : base(expressions, syntax)
        {
        }
    }
}
