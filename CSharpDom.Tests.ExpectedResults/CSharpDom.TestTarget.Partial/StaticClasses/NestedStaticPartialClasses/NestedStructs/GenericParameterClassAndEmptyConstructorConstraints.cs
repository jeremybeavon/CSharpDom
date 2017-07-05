namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
