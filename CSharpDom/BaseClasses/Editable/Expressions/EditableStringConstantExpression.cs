using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableStringConstantExpression : AbstractExpression, IStringConstantExpression
    {
        public abstract string Constant { get; set; }

        public abstract bool HasAtSymbol { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
