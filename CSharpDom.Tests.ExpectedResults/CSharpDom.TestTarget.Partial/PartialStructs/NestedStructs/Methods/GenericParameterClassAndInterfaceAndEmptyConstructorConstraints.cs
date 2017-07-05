namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
