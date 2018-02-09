using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableTypeReference : EditableVisitableObject, IEditableTypeReference
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
        }
    }
}
