namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
