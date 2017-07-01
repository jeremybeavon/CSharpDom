using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface INestedClassWrapper :
        INestedClass<
            IAttributeGroupWrapper,
            ITypeWrapper,
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
            IClassNestedInterfaceWrapper,
            IClassNestedStructCollectionWrapper,
            INestedDestructorWrapper,
            IStaticConstructorWrapper>
    {
    }
}
