using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IAbstractMethodWrapper :
        IAbstractMethod<
            IAttributeGroupWrapper,
            IAbstractTypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper>
    {
    }
}
