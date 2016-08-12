using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedDelegateWrapper :
        IStructNestedDelegate<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IDelegateParameterWrapper>
    {
    }
}
