namespace CSharpDom.TestTarget.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
