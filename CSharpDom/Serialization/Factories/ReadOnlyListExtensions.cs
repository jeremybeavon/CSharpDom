using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization.Factories
{
    public static class ReadOnlyListExtensions
    {
        public static List<TypeReference> ToGenericParameterListUsingFactory<TTypeReference>(
            this IReadOnlyList<TTypeReference> parameters)
            where TTypeReference : ITypeReference
        {
            return parameters.ToList(parameter => new TypeReferenceFactory(parameter).Value);
        }

        public static List<GenericParameterDeclaration> ToGenericParameterDeclarationListUsingFactory<TGenericParameterDeclaration>(
            this IReadOnlyList<TGenericParameterDeclaration> parameters)
            where TGenericParameterDeclaration : IGenericParameterDeclaration
        {
            return parameters.ToList(parameter => new GenericParameterDeclarationFactory(parameter).Value);
        }
    }
}
