using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableArgument<TExpression> : IArgument<TExpression>, IEditableArgument
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}
