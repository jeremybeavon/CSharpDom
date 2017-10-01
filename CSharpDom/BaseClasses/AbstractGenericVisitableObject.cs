using CSharpDom.Common;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericVisitableObject : IVisitable<IGenericVisitor>
    {
        public abstract void Accept(IGenericVisitor visitor);

        public abstract void AcceptChildren(IGenericVisitor visitor);

        public override string ToString()
        {
            return new StringBuilder().AppendLine(GetType().FullName + ":").Append(this.ToSourceCode()).ToString();
        }
    }
}
