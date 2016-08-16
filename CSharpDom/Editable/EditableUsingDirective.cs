using CSharpDom.Common;
using System;

namespace CSharpDom.Editable
{
    public class EditableUsingDirective : IUsingDirective
    {
        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
