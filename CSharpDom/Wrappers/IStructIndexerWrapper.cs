using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructIndexerWrapper :
        IStructIndexer<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            ITypeReferenceWrapper,
            IIndexerParameterWrapper,
            IStructAccessorWrapper>
    {
    }
}
