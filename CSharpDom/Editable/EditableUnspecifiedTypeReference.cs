using System;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableUnspecifiedTypeReference<TGenericParameter> : IUnspecifiedTypeReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public virtual IList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnspecifiedTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitUnspecifiedTypeReference(this, visitor);
        }
    }
}
