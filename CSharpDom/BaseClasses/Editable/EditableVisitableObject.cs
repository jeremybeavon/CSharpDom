using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableVisitableObject : AbstractGenericVisitableObject, IVisitable<IEditableVisitor>
    {
        public abstract void Accept(IEditableVisitor visitor);

        public abstract void AcceptChildren(IEditableVisitor visitor);
    }
}
