using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableIdentifierExpression : IIdentifierExpression
    {
        public abstract string Name { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
