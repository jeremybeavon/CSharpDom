using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface INestedDelegateWrapper :
        INestedDelegate<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IDelegateParameterWrapper>
    {
    }
}
