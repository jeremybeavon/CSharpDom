namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
