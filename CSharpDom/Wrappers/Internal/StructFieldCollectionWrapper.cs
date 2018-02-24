using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructFieldCollectionWrapper : AbstractWrapper<IStructFieldCollection>, IStructFieldCollectionWrapper
    {
        public StructFieldCollectionWrapper(IStructFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public IReadOnlyCollection<IStructConstantWrapper> Constants
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Count
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

        public IEnumerator<IStructFieldWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructFieldCollection<TField, TConstant>(
            IStructFieldCollection<TField, TConstant> fieldCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
