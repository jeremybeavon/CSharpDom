using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedAbstractClassWrapper :
        IStructNestedAbstractClass<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IClassReferenceWrapper,
            IInterfaceReferenceWrapper,
            IAbstractClassEventCollectionWrapper,
            IAbstractClassPropertyCollectionWrapper,
            IAbstractClassIndexerCollectionWrapper,
            IAbstractClassMethodCollectionWrapper,
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
