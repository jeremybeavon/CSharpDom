using System;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableStructReference<TGenericParameter> : IStructReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract string Name { get; set; }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

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
