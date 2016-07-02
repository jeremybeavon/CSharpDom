namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs
{
    public struct StructWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
