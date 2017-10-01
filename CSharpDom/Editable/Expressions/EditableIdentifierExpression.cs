using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableIdentifierExpression : AbstractExpression, IIdentifierExpression
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
