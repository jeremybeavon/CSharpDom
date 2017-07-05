namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
