using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableNamedAttributeValue<TExpression> : INamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract string Name { get; set; }

        public abstract TExpression Value { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
