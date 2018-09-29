using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IInternalExpression : IExpressionWithCodeAnalysis, IInternalGenericExpression
    {
    }
}
