using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructReference<TGenericParameter> : IStructReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructReferenceChildren(this, visitor);
        }
    }
}
