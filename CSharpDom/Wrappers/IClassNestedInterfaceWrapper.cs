using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassNestedInterfaceWrapper :
        IClassNestedInterface<IAttributeGroupWrapper, IClassTypeWrapper, IGenericParameterDeclarationWrapper, IInterfaceReferenceWrapper, IInterfaceEventWrapper, IInterfacePropertyWrapper, IInterfaceIndexerWrapper, IInterfaceMethodWrapper>
    {
    }
}
