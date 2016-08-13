using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedClassCollectionWrapper : AbstractWrapper<IStaticClassNestedClassCollection>, IStaticClassNestedClassCollectionWrapper
    {
        public StaticClassNestedClassCollectionWrapper(IStaticClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public IReadOnlyCollection<IStaticClassNestedAbstractClassWrapper> AbstractClasses
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

        public IPartialClassCollection PartialClasses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassNestedSealedClassWrapper> SealedClasses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassNestedStaticClassWrapper> StaticClasses
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

        public IEnumerator<IStaticClassNestedClassWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
