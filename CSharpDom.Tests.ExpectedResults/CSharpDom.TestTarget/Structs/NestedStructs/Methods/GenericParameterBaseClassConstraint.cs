namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
