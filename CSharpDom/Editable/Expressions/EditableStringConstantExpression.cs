using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableStringConstantExpression : IStringConstantExpression
    {
        public abstract string Constant { get; set; }

        public abstract bool HasAtSymbol { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
