using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        EditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IEditableStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
