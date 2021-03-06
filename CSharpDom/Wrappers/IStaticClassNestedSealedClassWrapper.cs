﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedSealedClassWrapper :
        IStaticClassNestedSealedClass<
            IAttributeGroupWrapper,
            IStaticTypeWrapper,
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
            IClassNestedInterfaceWrapper,
            IClassNestedStructCollectionWrapper,
            IStaticConstructorWrapper,
            IDestructorWrapper>
    {
    }
}
