namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
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
