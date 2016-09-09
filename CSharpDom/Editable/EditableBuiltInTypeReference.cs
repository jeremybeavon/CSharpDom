using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableBuiltInTypeReference : IBuiltInTypeReference
    {
        public abstract BuiltInType Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
