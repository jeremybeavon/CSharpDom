using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedStaticClassWrapper :
        IStaticClassNestedStaticClass<
            IAttributeGroupWrapper,
            IStaticTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IStaticClassEventCollectionWrapper,
            IStaticClassPropertyWrapper,
            INestedStaticClassMethodCollectionWrapper,
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
