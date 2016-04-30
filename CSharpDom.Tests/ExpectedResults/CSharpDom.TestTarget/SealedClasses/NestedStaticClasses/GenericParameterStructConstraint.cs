namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
