using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedInterfaceWrapper :
        IStaticClassNestedInterface<
            IAttributeGroupWrapper,
            IStaticTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IInterfaceEventWrapper,
            IInterfacePropertyWrapper,
            IInterfaceIndexerWrapper,
            IInterfaceMethodWrapper>
    {
    }
}
