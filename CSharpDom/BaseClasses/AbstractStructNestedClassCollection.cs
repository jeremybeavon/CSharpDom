using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        AbstractNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IStructNestedClass
        where TAbstractClass : IStructNestedAbstractClass
        where TSealedClass : IStructNestedSealedClass
        where TStaticClass : IStructNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
