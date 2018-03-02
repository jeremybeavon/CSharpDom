using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        EditableVisitableObject,
        IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract string Name { get; set; }

        public abstract TTypeReference PropertyType { get; set; }

        public abstract TExpression LambdaExpression { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void Accept(IEditableVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
