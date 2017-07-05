using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassNestedStructCollection<TStruct, TPartialStruct> :
        AbstractNestedStructCollection<TStruct, TPartialStruct>,
        IStaticClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStaticClassNestedStruct
        where TPartialStruct : IStaticClassNestedPartialStruct
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
