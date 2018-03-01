using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableVisitableObject,
        IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAccessor
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract TAccessor GetAccessor { get; set; }

        public abstract string Name { get; set; }

        public abstract TTypeReference PropertyType { get; set; }

        public abstract TAccessor SetAccessor { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProperty(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
