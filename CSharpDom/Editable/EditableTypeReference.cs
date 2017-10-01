using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableTypeReference : AbstractGenericVisitableObject, ITypeReference
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
