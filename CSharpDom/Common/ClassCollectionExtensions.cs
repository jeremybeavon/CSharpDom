namespace CSharpDom.Common
{
    public static class ClassCollectionExtensions
    {
        public static IClassTypeDefinitionsBuilder GetClassTypeDefinitions(
            this IClassCollection classCollection,
            bool includeNestedClasses = false)
        {
            return new ClassTypeDefinitionsBuilder(classCollection, includeNestedClasses);
        }
    }
}
