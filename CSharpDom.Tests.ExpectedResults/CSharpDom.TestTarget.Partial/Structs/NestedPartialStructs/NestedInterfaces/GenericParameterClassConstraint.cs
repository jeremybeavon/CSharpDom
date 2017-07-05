namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
