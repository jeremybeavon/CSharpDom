using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public class EditableConstant<TExpression> : IConstant<TExpression>
        where TExpression : IExpression
    {
        public virtual TExpression ConstantValue { get; set; }

        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
