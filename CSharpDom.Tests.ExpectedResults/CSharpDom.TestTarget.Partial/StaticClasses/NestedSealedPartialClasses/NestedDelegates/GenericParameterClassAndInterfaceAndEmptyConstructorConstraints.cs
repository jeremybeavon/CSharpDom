namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
