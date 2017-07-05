using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedClassCollectionWrapper : AbstractWrapper<IClassNestedClassCollection>, IClassNestedClassCollectionWrapper
    {
        public ClassNestedClassCollectionWrapper(IClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public IReadOnlyCollection<IClassNestedAbstractClassWrapper> AbstractClasses
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

        public IReadOnlyCollection<IClassNestedSealedClassWrapper> SealedClasses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IClassNestedStaticClassWrapper> StaticClasses
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

        public IEnumerator<IClassNestedClassWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
