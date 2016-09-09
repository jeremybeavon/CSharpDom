using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableTypeReference : ITypeReference
    {
         public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

         public virtual void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
