using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        AbstractGenericVisitableObject,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract TAccessor GetAccessor { get; set; }

        public abstract TTypeReference IndexerType { get; set; }

        public abstract IList<TParameter> Parameters { get; set; }

        public abstract TAccessor SetAccessor { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
