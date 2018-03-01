using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        EditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IEditableClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
