using System;
using System.Collections.Generic;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IEditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAccessor
        where TExpression : IEditableExpression
    {
        public abstract TExpression InitialValue { get; set; }
    }
}
