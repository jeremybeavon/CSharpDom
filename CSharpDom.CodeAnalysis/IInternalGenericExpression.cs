using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IInternalGenericExpression : IGenericExpressionWithCodeAnalysis, IHasNode<ExpressionSyntax>
    {
    }
}
