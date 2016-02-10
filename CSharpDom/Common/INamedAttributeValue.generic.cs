using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface INamedAttributeValue<TExpression> : INamedAttributeValue, IHasName
        where TExpression : IExpression
    {
        TExpression Value { get; }
    }
}
