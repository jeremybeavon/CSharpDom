using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IStaticClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public virtual StaticClassAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAccessor(this);
        }
    }
}
