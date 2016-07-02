namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs
{
    public struct StructWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
