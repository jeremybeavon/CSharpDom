using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedStructCollectionWrapper<TStruct, TPartialStruct> :
        AbstractNestedStructCollection<TStruct, TPartialStruct>,
        IWrapper<INestedStructCollection<TStruct, TPartialStruct>>
        where TStruct : INestedStruct
        where TPartialStruct : IPartialStruct
    {
        public NestedStructCollectionWrapper(INestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            WrappedObject = structCollection;
        }

        public override IReadOnlyCollection<TPartialStruct> PartialStructs
        {
            get { return WrappedObject.PartialStructs; }
        }

        public INestedStructCollection<TStruct, TPartialStruct> WrappedObject { get; private set; }

        protected override IReadOnlyCollection<TStruct> Structs
        {
            get { return WrappedObject; }
        }
    }
}
