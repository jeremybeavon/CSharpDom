using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable
{
    public class EditableClassNestedStructCollection<TStruct, TPartialStruct> :
        EditableNestedStructCollection<TStruct, TPartialStruct>,
        IClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IClassNestedStruct
        where TPartialStruct : IPartialStruct
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedStructCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedStructCollectionChildren(this, visitor);
        }
    }
}
