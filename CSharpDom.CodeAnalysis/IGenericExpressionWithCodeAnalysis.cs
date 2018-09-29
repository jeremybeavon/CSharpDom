using CSharpDom.Common.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IGenericExpressionWithCodeAnalysis : IEditableGenericExpression, IHasSyntax<ExpressionSyntax>
    {
    }
}
