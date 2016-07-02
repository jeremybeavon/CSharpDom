namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
