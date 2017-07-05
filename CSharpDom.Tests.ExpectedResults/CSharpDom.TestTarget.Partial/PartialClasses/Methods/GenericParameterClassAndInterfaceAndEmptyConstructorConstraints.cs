namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
