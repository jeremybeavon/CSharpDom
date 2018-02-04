using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableStringConstantExpression : IEditableConstantExpression<string>, IStringConstantExpression
    {
        new bool HasAtSymbol { get; set; }
    }
}