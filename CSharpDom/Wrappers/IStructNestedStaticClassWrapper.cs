using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedStaticClassWrapper :
        IStructNestedStaticClass<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
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
