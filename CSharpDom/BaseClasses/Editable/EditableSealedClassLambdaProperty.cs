using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        EditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IEditableSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassLambdaProperty(this);
        }
        
        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
