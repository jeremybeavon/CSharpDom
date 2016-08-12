using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassWrapper :
        IClass<
            INamespaceWrapper,
            IDocumentWrapper,
            IProjectWrapper,
            ISolutionWrapper,
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IClassReferenceWrapper,
            IInterfaceReferenceWrapper,
            IClassEventCollectionWrapper,
            IClassPropertyCollectionWrapper,
            IClassIndexerCollectionWrapper,
            IClassMethodCollectionWrapper,
            IClassFieldCollectionWrapper,
            IClassConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            IClassNestedClassCollectionWrapper,
            IClassNestedDelegateWrapper,
            IClassNestedEnumWrapper,
            IClassNestedInterfaceCollectionWrapper,
            IClassNestedStructCollectionWrapper,
            IDestructorWrapper,
            IStaticConstructorWrapper>
    {
    }
}
