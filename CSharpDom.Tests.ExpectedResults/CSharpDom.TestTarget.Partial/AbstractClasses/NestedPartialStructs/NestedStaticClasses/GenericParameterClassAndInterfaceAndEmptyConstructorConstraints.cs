namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
