namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
