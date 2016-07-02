namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Methods
{
    public sealed class SealedClassWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
