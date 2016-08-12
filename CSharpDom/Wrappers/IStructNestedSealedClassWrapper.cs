﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedSealedClassWrapper :
        IStructNestedSealedClass<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IClassReferenceWrapper,
            IInterfaceReferenceWrapper,
            ISealedClassEventCollectionWrapper,
            ISealedClassPropertyCollectionWrapper,
            ISealedClassIndexerCollectionWrapper,
            ISealedClassMethodCollectionWrapper,
            IClassFieldCollectionWrapper,
            IClassConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            IClassNestedClassCollectionWrapper,
            IClassNestedDelegateWrapper,
            IClassNestedEnumWrapper,
            IClassNestedInterfaceCollectionWrapper,
            IClassNestedStructCollectionWrapper,
            INestedDestructorWrapper,
            IStaticConstructorWrapper>
    {
    }
}
