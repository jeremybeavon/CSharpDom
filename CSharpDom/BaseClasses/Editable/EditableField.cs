using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableField<TExpression> : AbstractGenericVisitableObject, IField<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression InitialValue { get; set; }

        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
