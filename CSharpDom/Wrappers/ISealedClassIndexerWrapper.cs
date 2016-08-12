using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ISealedClassIndexerWrapper :
        ISealedClassIndexer<
            IAttributeGroupWrapper,
            ISealedTypeWrapper,
            ITypeReferenceWrapper,
            IIndexerParameterWrapper,
            IClassAccessorWrapper>
    {
    }
}
