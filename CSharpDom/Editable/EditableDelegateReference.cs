using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableDelegateReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IDelegateReference<TTypeReference>
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
            visitor.VisitDelegateReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }
    }
}
