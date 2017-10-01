using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEnumReference : AbstractGenericVisitableObject, IEnumReference
    {
        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
