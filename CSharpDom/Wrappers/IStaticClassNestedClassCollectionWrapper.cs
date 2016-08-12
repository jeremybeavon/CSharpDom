using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedClassCollectionWrapper :
        IStaticClassNestedClassCollection<
            IStaticClassNestedClassWrapper,
            IStaticClassNestedAbstractClassWrapper,
            IStaticClassNestedSealedClassWrapper,
            IStaticClassNestedStaticClassWrapper,
            IPartialClassCollection>
    {
    }
}
