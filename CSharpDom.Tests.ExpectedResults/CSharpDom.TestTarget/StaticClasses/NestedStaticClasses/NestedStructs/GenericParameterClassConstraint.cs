namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
