using System;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class Constant : IConstant<Expression>
    {
        public Expression ConstantValue { get; set; }

        public string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
