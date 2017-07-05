namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
