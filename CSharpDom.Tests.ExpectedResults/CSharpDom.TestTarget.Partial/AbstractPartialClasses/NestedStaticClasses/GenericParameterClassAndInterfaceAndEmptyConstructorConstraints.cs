namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
