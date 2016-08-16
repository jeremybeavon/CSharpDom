using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableGenericParameterReference : IGenericParameterReference
    {
        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
