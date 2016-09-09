using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableField<TExpression> : IField<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression InitialValue { get; set; }

        public abstract string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
