using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IIndexerWrapper :
        IIndexer<IAttributeGroupWrapper, ITypeWrapper, ITypeReferenceWrapper, IIndexerParameterWrapper, IAccessorWrapper>
    {
    }
}
