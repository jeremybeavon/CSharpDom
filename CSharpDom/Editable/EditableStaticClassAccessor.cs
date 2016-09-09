using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStaticClassAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IStaticClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract StaticClassAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAccessor(this);
        }
    }
}
