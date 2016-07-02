namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
