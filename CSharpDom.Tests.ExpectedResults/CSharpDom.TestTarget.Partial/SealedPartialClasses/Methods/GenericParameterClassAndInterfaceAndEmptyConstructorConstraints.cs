namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
