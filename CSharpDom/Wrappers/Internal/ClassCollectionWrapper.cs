using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassCollectionWrapper : AbstractWrapper<IClassCollection>, IClassCollectionWrapper
    {
        public ClassCollectionWrapper(IClassCollection field)
            : base(field)
        {
        }

        public IReadOnlyCollection<IAbstractClassWrapper> AbstractClasses
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

        public IReadOnlyCollection<ISealedClassWrapper> SealedClasses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassWrapper> StaticClasses
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

        public IEnumerator<IClassWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
