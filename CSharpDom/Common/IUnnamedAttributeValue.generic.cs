using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IUnnamedAttributeValue<TExpression> : IUnnamedAttributeValue
        where TExpression : IExpression
    {
        TExpression Value { get; }
    }
}
