namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
