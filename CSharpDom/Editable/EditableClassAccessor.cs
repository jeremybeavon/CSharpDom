using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public virtual ClassAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAccessor(this);
        }
    }
}
