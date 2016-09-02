using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ITypeWrapper :
        IType<
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IEventCollection,
            IPropertyCollection,
            IIndexerCollection,
            IMethodCollection,
            IFieldCollection,
            IConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            INestedClassCollectionWrapper,
            INestedDelegateWrapper,
            INestedEnumWrapper, 
            INestedInterfaceCollectionWrapper,
            INestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
