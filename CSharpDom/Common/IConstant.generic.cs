using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IConstant<TExpression> : IConstant, IHasName, IHasConstantValue<TExpression>
        where TExpression : IExpression
    {
    }
}
