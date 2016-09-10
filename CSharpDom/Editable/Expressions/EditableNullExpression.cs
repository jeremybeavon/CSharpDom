using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableNullExpression : INullExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
