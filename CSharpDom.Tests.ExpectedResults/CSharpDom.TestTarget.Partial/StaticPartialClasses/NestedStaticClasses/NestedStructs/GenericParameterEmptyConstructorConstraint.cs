namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
