using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableRawExpression : AbstractExpression, IRawExpression
    {
        public abstract string Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRawExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
