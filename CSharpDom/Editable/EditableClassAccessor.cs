using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableClassAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract ClassAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAccessor(this);
        }
    }
}
