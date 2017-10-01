using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableConstant<TExpression> : AbstractGenericVisitableObject, IConstant<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ConstantValue { get; set; }

        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstant(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
