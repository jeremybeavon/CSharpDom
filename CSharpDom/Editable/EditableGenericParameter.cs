using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableGenericParameter : IGenericParameter
    {
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameter(this, visitor);
        }
    }
}
