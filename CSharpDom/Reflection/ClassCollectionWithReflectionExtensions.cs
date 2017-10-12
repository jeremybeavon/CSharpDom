using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public static class ClassCollectionWithCodeAnalysisExtensions
    {
        public static IEnumerable<IClassTypeDefinitionWithReflection> GetAllClasses(
            this ClassCollectionWithReflection classCollection,
            bool includeNestedClasses = false)
        {
            return classCollection.GetClassTypeDefinitions(includeNestedClasses)
                .WithType<IClassTypeDefinitionWithReflection>();
        }
    }
}
