using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableConstantExpression<TConstant> : IEditableConstantExpression, IConstantExpression<TConstant>
    {
        new TConstant Constant { get; set; }
    }
}