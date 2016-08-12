using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface INestedInterfaceWrapper :
        INestedInterface<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IInterfaceEventWrapper,
            IInterfacePropertyWrapper,
            IInterfaceIndexerWrapper,
            IInterfaceMethodWrapper>
    {
    }
}
