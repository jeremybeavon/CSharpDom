using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        EditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
        public virtual StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructConstructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructConstructorChildren(this, visitor);
        }
    }
}
