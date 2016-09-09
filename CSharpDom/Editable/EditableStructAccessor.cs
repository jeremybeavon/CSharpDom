using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStructAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IStructAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        
        public abstract StructAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructAccessor(this);
        }
    }
}
