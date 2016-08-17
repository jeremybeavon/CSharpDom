using System;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableInterfaceReference<TGenericParameter> : IInterfaceReference<TGenericParameter>
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
            visitor.VisitInterfaceReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceReferenceChildren(this, visitor);
        }
    }
}
