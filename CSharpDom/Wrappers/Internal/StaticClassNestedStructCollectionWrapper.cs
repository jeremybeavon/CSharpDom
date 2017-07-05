using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedStructCollectionWrapper : AbstractWrapper<IStaticClassNestedStructCollection>,
        IStaticClassNestedStructCollectionWrapper
    {
        public StaticClassNestedStructCollectionWrapper(IStaticClassNestedStructCollection collection)
            : base(collection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassNestedPartialStruct> PartialStructs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IStaticClassNestedStructWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
