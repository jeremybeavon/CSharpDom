namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
