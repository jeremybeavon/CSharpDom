using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassWrapper :
        IStaticClass<
            INamespaceWrapper,
            IDocumentWrapper,
            IProjectWrapper,
            ISolutionWrapper,
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IStaticClassEventCollectionWrapper,
            IStaticClassPropertyWrapper,
            IStaticClassMethodCollectionWrapper,
            IStaticClassFieldCollectionWrapper,
            IStaticClassNestedClassCollectionWrapper,
            IStaticClassNestedDelegateWrapper,
            IStaticClassNestedEnumWrapper,
            IStaticClassNestedInterfaceWrapper,
            IStaticClassNestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
