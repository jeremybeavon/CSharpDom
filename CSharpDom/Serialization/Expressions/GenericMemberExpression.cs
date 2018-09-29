using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class GenericMemberExpression : IGenericMemberExpression<Expression, TypeReference>
    {
        public string MemberName { get; set; }

        public Expression ObjectExpression { get; set; }

        public List<TypeReference> GenericParameters { get; set; } = new List<TypeReference>();

        IReadOnlyList<TypeReference> IHasGenericParameters<TypeReference>.GenericParameters => GenericParameters;

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitGenericMemberExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitGenericMemberExpressionChildren(this, visitor);
        }
    }
}
