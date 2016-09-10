using CSharpDom.Common.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IExpressionWithCodeAnalysis : IExpression, IHasSyntax<ExpressionSyntax>
    {
    }
}
