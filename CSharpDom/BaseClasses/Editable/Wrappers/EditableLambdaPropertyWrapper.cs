using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableLambdaPropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        EditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IWrapper<IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public EditableLambdaPropertyWrapper(IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            WrappedObject = property;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override TTypeReference PropertyType
        {
            get { return WrappedObject.PropertyType; }
            set { WrappedObject.PropertyType = value; }
        }

        public IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> WrappedObject { get; private set; }

        public override TExpression LambdaExpression => WrappedObject.LambdaExpression;
    }
}