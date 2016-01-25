using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEnumReference : IEnumReference
    {
        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
