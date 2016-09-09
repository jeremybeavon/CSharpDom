using CSharpDom.Common;
using System;

namespace CSharpDom.Editable
{
    public abstract class EditableUsingDirective : IUsingDirective
    {
        public abstract string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
