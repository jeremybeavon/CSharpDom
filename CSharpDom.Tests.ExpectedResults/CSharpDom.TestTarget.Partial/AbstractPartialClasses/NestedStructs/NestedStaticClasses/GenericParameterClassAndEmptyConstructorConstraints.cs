namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
