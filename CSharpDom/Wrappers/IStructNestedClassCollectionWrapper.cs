using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedClassCollectionWrapper :
        IStructNestedClassCollection<
            IStructNestedClassWrapper,
            IStructNestedAbstractClassWrapper,
            IStructNestedSealedClassWrapper,
            IStructNestedStaticClassWrapper,
            IPartialClassCollection>
    {
    }
}
