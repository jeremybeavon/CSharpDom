using CSharpDom.Common.Expressions;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractExpression : AbstractObjectWithSourceCode, IVisitable<IGenericExpressionVisitor>
    {
        public abstract void Accept(IGenericExpressionVisitor visitor);

        public abstract void AcceptChildren(IGenericExpressionVisitor visitor);

        protected sealed override string ToSourceCodeText()
        {
            return this.ToSourceCode();
        }
    }
}
