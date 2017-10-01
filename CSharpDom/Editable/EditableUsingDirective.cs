using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableUsingDirective : AbstractGenericVisitableObject, IUsingDirective
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
