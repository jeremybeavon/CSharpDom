using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class ListInitializerExpression : IListInitializerExpression<CreateListExpression, Expression>
    {
        public ListInitializerExpression()
        {
            InitialValues = new List<List<Expression>>();
        }

        public CreateListExpression CreateListExpression { get; set; }

        public List<List<Expression>> InitialValues { get; set; }

        IReadOnlyList<IReadOnlyList<Expression>> IListInitializerExpression<CreateListExpression, Expression>.InitialValues
        {
            get { return InitialValues; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitListInitializerExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitListInitializerExpressionChildren(this, visitor);
        }
    }
}
