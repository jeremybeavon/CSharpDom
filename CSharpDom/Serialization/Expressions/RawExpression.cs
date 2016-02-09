using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class RawExpression : IRawExpression
    {
        public string Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            //visitor.VisitRawExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
