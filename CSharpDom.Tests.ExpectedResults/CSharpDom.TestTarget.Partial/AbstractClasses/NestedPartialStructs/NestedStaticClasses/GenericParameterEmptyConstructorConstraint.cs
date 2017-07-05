namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
