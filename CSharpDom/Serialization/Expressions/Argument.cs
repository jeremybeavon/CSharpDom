using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class Argument : IArgument<Expression>
    {
        public Expression Expression { get; set; }

        public string Name { get; set; }

        public OutArgument OutArgument { get; set; }

        public RefArgument RefArgument { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (OutArgument != null)
            {
                OutArgument.Accept(visitor);
            }
            else if (RefArgument != null)
            {
                RefArgument.Accept(visitor);
            }
            else
            {
                visitor.VisitArgument(this);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (OutArgument != null)
            {
                OutArgument.AcceptChildren(visitor);
            }
            else if (RefArgument != null)
            {
                RefArgument.AcceptChildren(visitor);
            }
            else
            {
                GenericExpressionVisitor.VisitArgumentChildren(this, visitor);
            }
        }
    }
}
