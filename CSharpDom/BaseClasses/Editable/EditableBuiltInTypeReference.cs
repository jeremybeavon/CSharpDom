using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableBuiltInTypeReference : EditableTypeReference, IEditableBuiltInTypeReference
    {
        public abstract BuiltInType Type { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }
    }
}
