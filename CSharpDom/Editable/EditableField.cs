using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public class EditableField<TExpression> : IField<TExpression>
        where TExpression : IExpression
    {
        public virtual TExpression InitialValue { get; set; }

        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
