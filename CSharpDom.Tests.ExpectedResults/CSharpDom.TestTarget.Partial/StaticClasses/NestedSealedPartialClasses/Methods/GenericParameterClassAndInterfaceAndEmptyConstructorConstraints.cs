namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
