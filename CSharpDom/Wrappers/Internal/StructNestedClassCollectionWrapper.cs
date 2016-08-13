using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedClassCollectionWrapper : AbstractWrapper<IStructNestedClassCollection>, IStructNestedClassCollectionWrapper
    {
        public StructNestedClassCollectionWrapper(IStructNestedClassCollection collection)
            : base(collection)
        {
        }

        public IReadOnlyCollection<IStructNestedAbstractClassWrapper> AbstractClasses
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

        public IReadOnlyCollection<IStructNestedSealedClassWrapper> SealedClasses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStructNestedStaticClassWrapper> StaticClasses
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

        public IEnumerator<IStructNestedClassWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
