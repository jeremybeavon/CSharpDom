using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public abstract class EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        AbstractGenericVisitableObject,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract ICollection<TAttributeGroup> AddAttributes { get; set; }

        public abstract TMethodBody AddBody { get; set; }

        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract TDelegateReference EventType { get; set; }
        
        public abstract string Name { get; set; }

        public abstract ICollection<TAttributeGroup> RemoveAttributes { get; set; }

        public abstract TMethodBody RemoveBody { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasEventPropertyBodyAttributes<TAttributeGroup>.AddAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(AddAttributes); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasEventPropertyBodyAttributes<TAttributeGroup>.RemoveAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(RemoveAttributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEventProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
