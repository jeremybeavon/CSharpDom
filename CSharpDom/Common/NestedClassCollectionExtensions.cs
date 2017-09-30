namespace CSharpDom.Common
{
    public static class NestedClassCollectionExtensions
    {
        public static IClassTypeDefinitionsBuilder GetClassTypeDefinitions(
            this INestedClassCollection classCollection,
            bool includeNestedClasses = false)
        {
            return new ClassTypeDefinitionsBuilder(classCollection, includeNestedClasses);
        }
    }
}
