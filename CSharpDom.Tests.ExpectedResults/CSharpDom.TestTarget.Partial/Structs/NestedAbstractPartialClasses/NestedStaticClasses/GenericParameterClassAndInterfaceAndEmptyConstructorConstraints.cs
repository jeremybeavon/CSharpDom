namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
