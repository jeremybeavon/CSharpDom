﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable
{
    public class EditableStaticClassNestedStructCollection<TStruct, TPartialStruct> :
        EditableNestedStructCollection<TStruct, TPartialStruct>,
        IStaticClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStaticClassNestedStruct
        where TPartialStruct : IPartialStruct
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedStructCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedStructCollectionChildren(this, visitor);
        }
    }
}