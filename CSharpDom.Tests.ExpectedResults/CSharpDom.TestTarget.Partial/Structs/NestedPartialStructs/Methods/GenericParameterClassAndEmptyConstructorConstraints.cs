namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
