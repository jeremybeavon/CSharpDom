using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IExplicitInterfaceIndexerWrapper :
        IExplicitInterfaceIndexer<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IInterfaceReferenceWrapper,
            ITypeReferenceWrapper,
            IIndexerParameterWrapper,
            IAccessorWrapper>
    {
    }
}
