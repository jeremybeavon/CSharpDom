using CSharpDom.Common.Statements;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractStatement : IVisitable<IGenericStatementVisitor>
    {
        public abstract void Accept(IGenericStatementVisitor visitor);

        public abstract void AcceptChildren(IGenericStatementVisitor visitor);

        public override string ToString()
        {
            return new StringBuilder().AppendLine(GetType().FullName + ":").Append(this.ToSourceCode()).ToString();
        }
    }
}
