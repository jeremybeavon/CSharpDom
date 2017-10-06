using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        AbstractGenericVisitableObject,
        IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TMethodBody : IMethodBody
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TMethodBody Body { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticConstructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticConstructorChildren(this, visitor);
        }
    }
}
