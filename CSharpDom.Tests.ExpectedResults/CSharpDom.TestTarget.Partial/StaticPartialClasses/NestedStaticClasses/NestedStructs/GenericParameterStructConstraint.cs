namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
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
