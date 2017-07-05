namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
