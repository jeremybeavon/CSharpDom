using CSharpDom.Common;
using CSharpDom.Text;
using System.Text;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericVisitableObject : AbstractObjectWithSourceCode, IVisitable<IGenericVisitor>
    {
        public abstract void Accept(IGenericVisitor visitor);

        public abstract void AcceptChildren(IGenericVisitor visitor);

        protected sealed override string ToSourceCodeText()
        {
            return this.ToSourceCode();
        }
    }
}
