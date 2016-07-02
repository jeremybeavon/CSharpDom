namespace CSharpDom.TestTarget.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
