namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
