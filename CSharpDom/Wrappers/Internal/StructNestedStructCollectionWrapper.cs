using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedStructCollectionWrapper : AbstractWrapper<IStructNestedStructCollection>, IStructNestedStructCollectionWrapper
    {
        public StructNestedStructCollectionWrapper(IStructNestedStructCollection collection)
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

        public IReadOnlyCollection<IPartialStruct> PartialStructs
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

        public IEnumerator<IStructNestedStructWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
