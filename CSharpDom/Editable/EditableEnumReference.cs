using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableEnumReference : IEnumReference
    {
        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
