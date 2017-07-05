namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
