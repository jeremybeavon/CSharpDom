using CSharpDom.Common.Statements;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractStatement : AbstractObjectWithSourceCode, IVisitable<IGenericStatementVisitor>
    {
        public abstract void Accept(IGenericStatementVisitor visitor);

        public abstract void AcceptChildren(IGenericStatementVisitor visitor);

        protected sealed override string ToSourceCodeText()
        {
            return this.ToSourceCode();
        }
    }
}
