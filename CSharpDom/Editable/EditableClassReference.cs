using System;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableClassReference<TGenericParameter> : IClassReference<TGenericParameter>
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
            visitor.VisitClassReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }
    }
}
