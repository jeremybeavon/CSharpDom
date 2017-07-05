namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
