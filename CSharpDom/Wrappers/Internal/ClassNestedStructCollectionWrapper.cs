using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedStructCollectionWrapper : AbstractWrapper<IClassNestedStructCollection>, IClassNestedStructCollectionWrapper
    {
        public ClassNestedStructCollectionWrapper(IClassNestedStructCollection collection)
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

        public IReadOnlyCollection<IClassNestedPartialStruct> PartialStructs
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

        public IEnumerator<IClassNestedStructWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
