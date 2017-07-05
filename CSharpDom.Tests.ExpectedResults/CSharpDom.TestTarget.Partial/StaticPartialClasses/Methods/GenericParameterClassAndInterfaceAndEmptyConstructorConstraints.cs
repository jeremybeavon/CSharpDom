namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
