namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
