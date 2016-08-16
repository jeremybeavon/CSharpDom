using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public class EditableUnnamedAttributeValue<TExpression> : IUnnamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public virtual TExpression Value { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
