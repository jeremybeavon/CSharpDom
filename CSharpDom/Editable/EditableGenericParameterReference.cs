using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableGenericParameterReference : IGenericParameterReference
    {
        public abstract string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
