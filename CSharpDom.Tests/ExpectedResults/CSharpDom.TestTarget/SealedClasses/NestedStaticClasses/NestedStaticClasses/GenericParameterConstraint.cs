namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
