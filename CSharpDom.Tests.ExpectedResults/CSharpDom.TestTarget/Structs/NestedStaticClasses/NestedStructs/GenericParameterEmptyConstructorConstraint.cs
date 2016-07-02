namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs
{
    public struct StructWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
