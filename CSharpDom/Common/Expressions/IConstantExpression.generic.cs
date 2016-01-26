namespace CSharpDom.Common.Expressions
{
    public interface IConstantExpression<TConstant> : IConstantExpression
    {
        TConstant Constant { get; }
    }
}
