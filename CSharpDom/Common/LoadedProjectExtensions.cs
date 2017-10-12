namespace CSharpDom.Common
{
    public static class LoadedProjectExtensions
    {
        public static IClassTypeDefinitionsBuilder GetClassTypeDefinitions<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            this ILoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedProject,
            bool includeNestedClasses = false)
            where TSolution : ISolution
            where TProject : IProject
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStructCollection : IStructCollection
        {
            ClassTypeDefinitionsBuilder builder = new ClassTypeDefinitionsBuilder(includeNestedClasses);
            GenericVisitor.VisitLoadedProjectChildren(loadedProject, builder);
            return builder;
        }
    }
}
