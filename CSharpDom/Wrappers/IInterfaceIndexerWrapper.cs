﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IInterfaceIndexerWrapper :
        IInterfaceIndexer<
            IAttributeGroupWrapper,
            IInterfaceTypeWrapper,
            ITypeReferenceWrapper,
            IIndexerParameterWrapper,
            IInterfaceAccessorWrapper>
    {
    }
}
