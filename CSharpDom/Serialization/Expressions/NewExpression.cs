using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class NewExpression : INewExpression<TypeReference, Argument>
    {
        public NewExpression()
        {
            Parameters = new List<Argument>();
        }

        public List<Argument> Parameters { get; set; }

        public TypeReference Type { get; set; }

        IReadOnlyList<Argument> INewExpression<TypeReference, Argument>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }
    }
}
