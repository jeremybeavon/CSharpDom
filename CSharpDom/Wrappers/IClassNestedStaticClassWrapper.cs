using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassNestedStaticClassWrapper :
        IClassNestedStaticClass<
            IAttributeGroupWrapper,
            IClassTypeWrapper,
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
