﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers
{
    public interface IClassNestedClassCollectionWrapper :
        IClassNestedClassCollection<IClassNestedClassWrapper, IClassNestedAbstractClassWrapper, IClassNestedSealedClassWrapper, IClassNestedStaticClassWrapper, IPartialClassCollection>
    {
    }
}
