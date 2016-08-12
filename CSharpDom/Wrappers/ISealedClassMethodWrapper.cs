using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ISealedClassMethodWrapper :
        ISealedClassMethod<
            IAttributeGroupWrapper,
            ISealedTypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
