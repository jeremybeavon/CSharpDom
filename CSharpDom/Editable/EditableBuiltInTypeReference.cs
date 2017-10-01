using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableBuiltInTypeReference : AbstractGenericVisitableObject, IBuiltInTypeReference
    {
        public abstract BuiltInType Type { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
