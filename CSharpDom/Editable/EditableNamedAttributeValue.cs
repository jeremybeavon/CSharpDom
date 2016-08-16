using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public class EditableNamedAttributeValue<TExpression> : INamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public virtual string Name { get; set; }

        public virtual TExpression Value { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
