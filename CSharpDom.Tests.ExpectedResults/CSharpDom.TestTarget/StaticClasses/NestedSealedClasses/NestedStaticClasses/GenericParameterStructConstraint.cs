namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
