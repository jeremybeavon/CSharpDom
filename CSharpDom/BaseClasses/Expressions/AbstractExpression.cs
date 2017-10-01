using CSharpDom.Common.Expressions;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractExpression : IVisitable<IGenericExpressionVisitor>
    {
        public abstract void Accept(IGenericExpressionVisitor visitor);

        public abstract void AcceptChildren(IGenericExpressionVisitor visitor);

        public override string ToString()
        {
            return new StringBuilder().AppendLine(GetType().FullName + ":").Append(this.ToSourceCode()).ToString();
        }
    }
}
