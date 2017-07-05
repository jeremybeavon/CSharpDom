using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassNestedStructCollection<TStruct, TPartialStruct> :
        AbstractNestedStructCollection<TStruct, TPartialStruct>,
        IClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IClassNestedStruct
        where TPartialStruct : IClassNestedPartialStruct
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
