using CSharpDom.Common.Expressions;

namespace CSharpDom.NotSupported
{
    public sealed class ExpressionNotSupported : VisitableNotSupported<IGenericExpressionVisitor>, IExpression
    {
    }
}
