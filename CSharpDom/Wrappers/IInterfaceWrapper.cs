using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IInterfaceWrapper :
        IInterface<
            INamespaceWrapper,
            IDocumentWrapper,
            IProjectWrapper,
            ISolutionWrapper,
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IInterfaceEventWrapper,
            IInterfacePropertyWrapper,
            IInterfaceIndexerWrapper,
            IInterfaceMethodWrapper>
    {
    }
}
