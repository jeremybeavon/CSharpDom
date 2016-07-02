namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
