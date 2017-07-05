namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
