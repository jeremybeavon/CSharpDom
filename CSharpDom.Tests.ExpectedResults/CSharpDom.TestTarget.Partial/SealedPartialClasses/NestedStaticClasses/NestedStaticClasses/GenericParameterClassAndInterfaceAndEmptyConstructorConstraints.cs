namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
