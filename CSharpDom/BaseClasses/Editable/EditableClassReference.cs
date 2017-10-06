using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IClassReference<TTypeReference>
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
            visitor.VisitClassReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }
    }
}
