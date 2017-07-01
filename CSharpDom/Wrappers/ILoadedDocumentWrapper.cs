using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ILoadedDocumentWrapper :
        ILoadedDocument<
            ISolutionWrapper,
            IProjectWrapper,
            IDocumentWrapper,
            IUsingDirectiveWrapper, 
            IAttributeGroupWrapper,
            INamespaceWrapper,
            IClassCollectionWrapper,
            IDelegateWrapper,
            IEnumWrapper,
            IInterfaceWrapper,
            IStructCollectionWrapper>
    {
    }
}
