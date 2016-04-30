namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
