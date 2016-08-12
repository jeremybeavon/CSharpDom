using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IDelegateWrapper :
        IDelegate<
            INamespaceWrapper,
            IDocumentWrapper,
            IProjectWrapper,
            ISolutionWrapper,
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IDelegateParameterWrapper>
    {
    }
}
