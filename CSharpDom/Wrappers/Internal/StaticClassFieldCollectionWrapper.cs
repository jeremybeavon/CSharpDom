using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StaticClassFieldCollectionWrapper : AbstractWrapper<IStaticClassFieldCollection>, IStaticClassFieldCollectionWrapper
    {
        public StaticClassFieldCollectionWrapper(IStaticClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public IReadOnlyCollection<IStaticClassConstantWrapper> Constants
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

        public IEnumerator<IStaticClassFieldWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassFieldCollection<TField, TConstant>(
            IStaticClassFieldCollection<TField, TConstant> fieldCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
