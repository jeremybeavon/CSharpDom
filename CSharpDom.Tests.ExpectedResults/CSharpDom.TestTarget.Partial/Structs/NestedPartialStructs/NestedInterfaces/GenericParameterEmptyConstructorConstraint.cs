namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
