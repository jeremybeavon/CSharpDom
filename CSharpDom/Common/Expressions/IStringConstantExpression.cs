namespace CSharpDom.Common.Expressions
{
    public interface IStringConstantExpression : IConstantExpression<string>
    {
        bool HasAtSymbol { get; }
    }
}
