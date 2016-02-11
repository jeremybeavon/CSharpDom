using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IField<TExpression> : IField, IHasName, IHasInitialValue<TExpression>
        where TExpression : IExpression
    {
    }
}
