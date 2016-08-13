using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassFieldCollectionWrapper : AbstractWrapper<IClassFieldCollection>, IClassFieldCollectionWrapper
    {
        public ClassFieldCollectionWrapper(IClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public IReadOnlyCollection<IClassConstantWrapper> Constants
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

        public IEnumerator<IClassFieldWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassFieldCollection<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
