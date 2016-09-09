using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableConstant<TExpression> : IConstant<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ConstantValue { get; set; }

        public abstract string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
