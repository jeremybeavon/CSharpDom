using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableUnspecifiedTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IUnspecifiedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract IList<TTypeReference> GenericParameters { get; set; }

        public abstract string Name { get; set; }

        IReadOnlyList<TTypeReference> IHasGenericParameters<TTypeReference>.GenericParameters
        {
            get { return new ReadOnlyCollection<TTypeReference>(GenericParameters); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnspecifiedTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitUnspecifiedTypeReference(this, visitor);
        }
    }
}
