namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
