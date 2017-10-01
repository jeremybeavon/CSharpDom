using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableEnumReference : AbstractGenericVisitableObject, IEnumReference
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
