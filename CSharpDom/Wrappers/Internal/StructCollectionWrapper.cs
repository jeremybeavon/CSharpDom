using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructCollectionWrapper : AbstractWrapper<IStructCollection>, IStructCollectionWrapper
    {
        public StructCollectionWrapper(IStructCollection field)
            : base(field)
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

        public IEnumerator<IStructWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructCollection<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
