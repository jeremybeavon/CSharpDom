namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
