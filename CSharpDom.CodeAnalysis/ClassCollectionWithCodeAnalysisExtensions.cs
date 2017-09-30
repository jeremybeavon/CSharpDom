using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public static class ClassCollectionWithCodeAnalysisExtensions
    {
        public static IEnumerable<IClassTypeDefinitionWithCodeAnalysis> GetClassTypeDefinitionsWithCodeAnalysis(
            this IClassCollectionWithCodeAnalysis classCollection,
            bool includeNestedClasses = false)
        {
            return classCollection.GetClassTypeDefinitions(includeNestedClasses)
                .WithType<IClassTypeDefinitionWithCodeAnalysis>();
        }
    }
}
