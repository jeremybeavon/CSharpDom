using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableInterfaceReference<TGenericParameter> : IInterfaceReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceReferenceChildren(this, visitor);
        }
    }
}
