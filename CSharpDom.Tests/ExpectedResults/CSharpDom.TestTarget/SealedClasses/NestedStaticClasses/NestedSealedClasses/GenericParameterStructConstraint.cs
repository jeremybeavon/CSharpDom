namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
