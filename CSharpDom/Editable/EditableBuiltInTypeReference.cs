using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableBuiltInTypeReference : IBuiltInTypeReference
    {
        public virtual BuiltInType Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
