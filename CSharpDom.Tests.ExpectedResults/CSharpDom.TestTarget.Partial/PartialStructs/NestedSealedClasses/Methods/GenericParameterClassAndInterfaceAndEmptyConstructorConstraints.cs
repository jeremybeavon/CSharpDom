namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
