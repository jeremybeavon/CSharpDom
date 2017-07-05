namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
