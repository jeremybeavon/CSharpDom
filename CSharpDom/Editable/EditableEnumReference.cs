using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableEnumReference : IEnumReference
    {
        public abstract string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
