using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedInterfaceWrapper :
        IStructNestedInterface<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IInterfaceEventWrapper,
            IInterfacePropertyWrapper,
            IInterfaceIndexerWrapper,
            IInterfaceMethodWrapper>
    {
    }
}
