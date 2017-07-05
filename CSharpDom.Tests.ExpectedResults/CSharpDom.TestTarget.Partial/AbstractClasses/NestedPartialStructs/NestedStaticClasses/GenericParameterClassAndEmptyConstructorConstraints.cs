namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
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
