using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization.Factories
{
    public static class ReadOnlyListExtensions
    {
        public static List<GenericParameter> ToGenericParameterListUsingFactory<TGenericParameter>(
            this IReadOnlyList<TGenericParameter> parameters)
            where TGenericParameter : IGenericParameter
        {
            return parameters.ToList(parameter => new GenericParameterFactory(parameter).Value);
        }

        public static List<GenericParameterDeclaration> ToGenericParameterDeclarationListUsingFactory<TGenericParameterDeclaration>(
            this IReadOnlyList<TGenericParameterDeclaration> parameters)
            where TGenericParameterDeclaration : IGenericParameterDeclaration
        {
            return parameters.ToList(parameter => new GenericParameterDeclarationFactory(parameter).Value);
        }
    }
}
