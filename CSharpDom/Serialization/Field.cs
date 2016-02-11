using System;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class Field : IField<Expression>
    {
        public Expression InitialValue { get; set; }

        public string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
