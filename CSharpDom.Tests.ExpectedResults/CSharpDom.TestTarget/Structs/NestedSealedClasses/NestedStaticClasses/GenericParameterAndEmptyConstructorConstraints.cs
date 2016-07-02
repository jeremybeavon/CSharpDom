namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
