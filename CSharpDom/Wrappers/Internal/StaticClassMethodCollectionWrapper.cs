using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassMethodCollectionWrapper : AbstractWrapper<IStaticClassMethodCollection>, IStaticClassMethodCollectionWrapper
    {
        public StaticClassMethodCollectionWrapper(IStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IExtensionMethodWrapper> ExtensionMethods
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

        public IEnumerator<IStaticClassMethodWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
