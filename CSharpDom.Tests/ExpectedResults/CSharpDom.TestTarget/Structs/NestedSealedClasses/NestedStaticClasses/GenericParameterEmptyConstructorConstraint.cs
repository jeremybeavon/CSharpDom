namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
